using System.Text.Json;

namespace MoneyTrack
{
    public partial class Cheltuieli : Form
    {
        string expensesPath = "expenses.json";
        string usersPath = "users.json";

        string currentUsername;

        Expense expenseForEdit = null;

        public decimal LastExpenseAmount;

        public Cheltuieli(string username)
        {
            InitializeComponent();

            currentUsername = username;

            PregatesteCategorii();
        }

        public Cheltuieli(string username, Expense expense)
        {
            InitializeComponent();

            currentUsername = username;
            expenseForEdit = expense;

            PregatesteCategorii();

            textBoxSuma.Text = expense.Amount.ToString();
            textBoxDescriere.Text = expense.Description;
            comboBoxCategorie.Text = expense.Category;
            dateTimePicker1.Value = expense.Date;

            button1.Text = "SALVEAZA MODIFICARILE";
        }

        private void PregatesteCategorii()
        {
            comboBoxCategorie.Items.Clear();

            comboBoxCategorie.Items.Add("Sanatate");
            comboBoxCategorie.Items.Add("Timp liber");
            comboBoxCategorie.Items.Add("Casa");
            comboBoxCategorie.Items.Add("Educatie");
            comboBoxCategorie.Items.Add("Cadouri");
            comboBoxCategorie.Items.Add("Produse alimentare");
            comboBoxCategorie.Items.Add("Iesit in oras");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSuma.Text == "" || comboBoxCategorie.Text == "")
            {
                MessageBox.Show("Completeaza suma si categoria!");
                return;
            }

            decimal suma;

            if (!decimal.TryParse(textBoxSuma.Text, out suma))
            {
                MessageBox.Show("Suma trebuie sa fie numar!");
                return;
            }

            if (suma <= 0)
            {
                MessageBox.Show("Suma trebuie sa fie mai mare decat 0!");
                return;
            }

            List<Expense> expenses = LoadExpenses();

            decimal bugetTotal = GetBugetTotal();

            decimal totalCheltuitFaraCheltuialaCurenta = expenses
                .Where(x => x.Username == currentUsername)
                .Where(x => expenseForEdit == null || x.Id != expenseForEdit.Id)
                .Sum(x => x.Amount);

            decimal totalDupaSalvare = totalCheltuitFaraCheltuialaCurenta + suma;

            if (totalDupaSalvare > bugetTotal)
            {
                decimal bugetRamas = bugetTotal - totalCheltuitFaraCheltuialaCurenta;

                MessageBox.Show(
                    "Nu poti salva aceasta cheltuiala deoarece depaseste bugetul!\n\n" +
                    "Buget ramas disponibil: " + bugetRamas + " lei\n" +
                    "Suma introdusa: " + suma + " lei"
                );

                return;
            }

            if (expenseForEdit == null)
            {
                Expense expense = new Expense
                {
                    Id = Guid.NewGuid(),
                    Username = currentUsername,
                    Amount = suma,
                    Description = textBoxDescriere.Text,
                    Category = comboBoxCategorie.Text,
                    Date = dateTimePicker1.Value
                };

                expenses.Add(expense);

                LastExpenseAmount = suma;

                SaveExpenses(expenses);

                MessageBox.Show("Cheltuiala a fost salvata!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Expense foundExpense = expenses.FirstOrDefault(x => x.Id == expenseForEdit.Id);

                if (foundExpense != null)
                {
                    foundExpense.Amount = suma;
                    foundExpense.Description = textBoxDescriere.Text;
                    foundExpense.Category = comboBoxCategorie.Text;
                    foundExpense.Date = dateTimePicker1.Value;
                }

                LastExpenseAmount = suma;

                SaveExpenses(expenses);

                MessageBox.Show("Cheltuiala a fost modificata!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private decimal GetBugetTotal()
        {
            if (!File.Exists(usersPath))
            {
                return 0;
            }

            string json = File.ReadAllText(usersPath);

            if (json == "")
            {
                return 0;
            }

            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();

            User userGasit = users.FirstOrDefault(x => x.Username == currentUsername);

            if (userGasit == null)
            {
                return 0;
            }

            decimal buget;

            if (!decimal.TryParse(userGasit.Budget, out buget))
            {
                return 0;
            }

            return buget;
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

        private void SaveExpenses(List<Expense> expenses)
        {
            string json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(expensesPath, json);
        }
    }
}