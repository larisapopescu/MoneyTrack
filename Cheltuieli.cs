using System.Text.Json;

namespace MoneyTrack
{
    public partial class Cheltuieli : Form
    {
        string expensesPath = "expenses.json";

        string currentUsername;
        public decimal LastExpenseAmount;

        public Cheltuieli(string username)
        {
            InitializeComponent();

            currentUsername = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSuma.Text == "" || comboBoxCategorie.Text == "")
            {
                MessageBox.Show("Completeaza campurile!");
                return;
            }

            decimal suma;

            if (!decimal.TryParse(textBoxSuma.Text, out suma))
            {
                MessageBox.Show("Suma trebuie sa fie numar!");
                return;
            }

            List<Expense> expenses = new List<Expense>();

            if (File.Exists(expensesPath))
            {
                string json = File.ReadAllText(expensesPath);

                if (json != "")
                {
                    expenses = JsonSerializer.Deserialize<List<Expense>>(json);
                }
            }

            Expense expense = new Expense
            {
                Username = currentUsername,
                Amount = suma,
                Description = textBoxDescriere.Text,
                Category = comboBoxCategorie.Text,
                Date = dateTimePicker1.Value
            };

            expenses.Add(expense);

            LastExpenseAmount = suma;

            string newJson = JsonSerializer.Serialize(expenses, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(expensesPath, newJson);

            MessageBox.Show("Cheltuiala a fost salvata!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}