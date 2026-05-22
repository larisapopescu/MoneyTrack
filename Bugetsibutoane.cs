using System.Text.Json;
using System.Text;
using Microsoft.VisualBasic;

namespace MoneyTrack
{
    public partial class Bugetsibutoane : Form
    {
        string currentUsername;

        decimal initialBudget;
        decimal currentBudget;
        string currentCurrency;

        string usersPath = "users.json";
        string expensesPath = "expenses.json";

        public Bugetsibutoane(string budget, string currency, string username)
        {
            InitializeComponent();

            currentUsername = username;

            decimal.TryParse(budget, out initialBudget);
            currentCurrency = currency;

            RefreshBudgetLabel();

            button2.Click -= button2_Click;
            button2.Click += button2_Click;

            button3.Click -= button3_Click;
            button3.Click += button3_Click;

            button4.Click -= button4_Click;
            button4.Click += button4_Click;
        }

        private void RefreshBudgetLabel()
        {
            decimal totalCheltuit = GetTotalExpensesForCurrentUser();

            currentBudget = initialBudget - totalCheltuit;

            labelBuget.Text = "BUGET: " + currentBudget + " " + currentCurrency;

            if (currentBudget < 0)
            {
                labelBuget.Text = "BUGET DEPASIT: " + currentBudget + " " + currentCurrency;
            }
        }

        private decimal GetTotalExpensesForCurrentUser()
        {
            List<Expense> expenses = LoadExpenses();

            decimal total = expenses
                .Where(x => x.Username == currentUsername)
                .Sum(x => x.Amount);

            return total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshBudgetLabel();

            if (currentBudget <= 0)
            {
                MessageBox.Show("Bugetul a fost atins sau depasit! Nu mai poti adauga cheltuieli.");
                return;
            }

            Cheltuieli form = new Cheltuieli(currentUsername);

            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshBudgetLabel();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Expense> expenses = LoadExpenses()
                .Where(x => x.Username == currentUsername)
                .ToList();

            if (expenses.Count == 0)
            {
                MessageBox.Show("Nu exista cheltuieli de exportat!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.FileName = "cheltuieli_" + currentUsername + ".csv";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Suma,Categorie,Data,Descriere");

            foreach (Expense expense in expenses)
            {
                string categorie = expense.Category ?? "";
                string descriere = expense.Description ?? "";

                categorie = categorie.Replace("\"", "\"\"");
                descriere = descriere.Replace("\"", "\"\"");

                sb.AppendLine(
                    expense.Amount + "," +
                    "\"" + categorie + "\"," +
                    "\"" + expense.Date.ToShortDateString() + "\"," +
                    "\"" + descriere + "\""
                );
            }

            File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("Datele au fost exportate cu succes!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valoare = Interaction.InputBox(
                "Introdu suma pe care vrei sa o adaugi la buget:",
                "Adaugare buget",
                "0"
            );

            if (valoare == "")
            {
                return;
            }

            decimal sumaAdaugata;

            if (!decimal.TryParse(valoare, out sumaAdaugata))
            {
                MessageBox.Show("Suma introdusa nu este valida!");
                return;
            }

            if (sumaAdaugata <= 0)
            {
                MessageBox.Show("Suma trebuie sa fie mai mare decat 0!");
                return;
            }

            initialBudget = initialBudget + sumaAdaugata;

            SalveazaBugetulNou();

            RefreshBudgetLabel();

            MessageBox.Show("Bugetul a fost actualizat cu succes!");
        }

        private void SalveazaBugetulNou()
        {
            if (!File.Exists(usersPath))
            {
                return;
            }

            string json = File.ReadAllText(usersPath);

            if (json == "")
            {
                return;
            }

            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();

            User userGasit = users.FirstOrDefault(x => x.Username == currentUsername);

            if (userGasit != null)
            {
                userGasit.Budget = initialBudget.ToString();
            }

            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(usersPath, newJson);
        }

        private List<Expense> LoadExpenses()
        {
            if (!File.Exists(expensesPath))
            {
                return new List<Expense>();
            }

            string json = File.ReadAllText(expensesPath);

            if (json == "")
            {
                return new List<Expense>();
            }

            return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalCheltuieli form = new TotalCheltuieli(currentUsername);
            form.ShowDialog();

            RefreshBudgetLabel();
        }
    }
}