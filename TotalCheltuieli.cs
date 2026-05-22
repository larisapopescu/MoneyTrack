using System.Text.Json;
using Microsoft.VisualBasic;

namespace MoneyTrack
{
    public partial class TotalCheltuieli : Form
    {
        string currentUsername;
        string expensesPath = "expenses.json";

        List<Expense> allExpenses = new List<Expense>();
        List<Expense> filteredExpenses = new List<Expense>();

        public TotalCheltuieli(string username)
        {
            InitializeComponent();

            currentUsername = username;

            dataGridViewExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenses.MultiSelect = false;
            dataGridViewExpenses.ReadOnly = true;
            dataGridViewExpenses.AllowUserToAddRows = false;
            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewExpenses.DataBindingComplete += dataGridViewExpenses_DataBindingComplete;

            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonFilter.Click += buttonFilter_Click;
            buttonSearch.Click += buttonSearch_Click;
            buttonStatisticiGrafic.Click += buttonStatisticiGrafic_Click;
            buttonReturn.Click += buttonReturn_Click;

            LoadExpenses();
            AfiseazaToateCheltuielile();
        }

        private void LoadExpenses()
        {
            if (!File.Exists(expensesPath))
            {
                allExpenses = new List<Expense>();
                return;
            }

            string json = File.ReadAllText(expensesPath);

            if (json == "")
            {
                allExpenses = new List<Expense>();
                return;
            }

            allExpenses = JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();

            bool changed = false;

            foreach (Expense expense in allExpenses)
            {
                if (expense.Id == Guid.Empty)
                {
                    expense.Id = Guid.NewGuid();
                    changed = true;
                }
            }

            if (changed)
            {
                SaveExpenses();
            }
        }

        private void SaveExpenses()
        {
            string json = JsonSerializer.Serialize(allExpenses, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(expensesPath, json);
        }

        private void AfiseazaToateCheltuielile()
        {
            filteredExpenses = allExpenses
                .Where(x => x.Username == currentUsername)
                .ToList();

            AfiseazaInTabel();
        }

        private void AfiseazaInTabel()
        {
            var data = filteredExpenses
                .Select(x => new
                {
                    Id = x.Id,
                    Suma = x.Amount,
                    Categorie = x.Category,
                    Data = x.Date.ToShortDateString(),
                    Descriere = x.Description
                })
                .ToList();

            dataGridViewExpenses.DataSource = data;

            if (dataGridViewExpenses.Columns["Id"] != null)
            {
                dataGridViewExpenses.Columns["Id"].Visible = false;
            }

            dataGridViewExpenses.ClearSelection();
        }

        private Expense GetSelectedExpense()
        {
            if (dataGridViewExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza o cheltuiala din tabel!");
                return null;
            }

            Guid id = (Guid)dataGridViewExpenses.SelectedRows[0].Cells["Id"].Value;

            Expense selectedExpense = allExpenses.FirstOrDefault(x => x.Id == id);

            if (selectedExpense == null)
            {
                MessageBox.Show("Cheltuiala selectata nu a fost gasita!");
                return null;
            }

            return selectedExpense;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Expense selectedExpense = GetSelectedExpense();

            if (selectedExpense == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Vrei sa editezi aceasta cheltuiala?",
                "Confirmare editare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            Cheltuieli form = new Cheltuieli(currentUsername, selectedExpense);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadExpenses();
                AfiseazaToateCheltuielile();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Expense selectedExpense = GetSelectedExpense();

            if (selectedExpense == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Sigur vrei sa stergi aceasta cheltuiala?",
                "Confirmare stergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            allExpenses.RemoveAll(x => x.Id == selectedExpense.Id);

            SaveExpenses();

            LoadExpenses();
            AfiseazaToateCheltuielile();

            MessageBox.Show("Cheltuiala a fost stearsa!");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            List<string> categorii = allExpenses
                .Where(x => x.Username == currentUsername)
                .Select(x => x.Category)
                .Where(x => x != null && x != "")
                .Distinct()
                .ToList();

            if (categorii.Count == 0)
            {
                MessageBox.Show("Nu exista categorii pentru filtrare!");
                return;
            }

            string mesajCategorii = "Categorii existente:\n\n";

            foreach (string categorie in categorii)
            {
                mesajCategorii += "- " + categorie + "\n";
            }

            mesajCategorii += "\nScrie categoria dupa care vrei sa filtrezi:";

            string categorieAleasa = Interaction.InputBox(
                mesajCategorii,
                "Filtrare dupa categorie",
                ""
            );

            if (categorieAleasa == "")
            {
                return;
            }

            filteredExpenses = allExpenses
                .Where(x => x.Username == currentUsername)
                .Where(x => x.Category != null &&
                            x.Category.ToLower() == categorieAleasa.ToLower())
                .ToList();

            AfiseazaInTabel();

            if (filteredExpenses.Count == 0)
            {
                MessageBox.Show("Nu exista cheltuieli pentru categoria introdusa!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string cautare = Interaction.InputBox(
                "Introdu textul cautat in descriere:",
                "Cautare cheltuieli",
                ""
            );

            if (cautare == "")
            {
                return;
            }

            filteredExpenses = allExpenses
                .Where(x => x.Username == currentUsername)
                .Where(x => x.Description != null &&
                            x.Description.ToLower().Contains(cautare.ToLower()))
                .ToList();

            AfiseazaInTabel();

            if (filteredExpenses.Count == 0)
            {
                MessageBox.Show("Nu exista cheltuieli care contin acest text in descriere!");
            }
        }

        private void buttonStatisticiGrafic_Click(object sender, EventArgs e)
        {
            StatisticiGrafic form = new StatisticiGrafic(currentUsername);
            form.ShowDialog();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewExpenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewExpenses.Rows)
            {
                if (row.Cells["Suma"].Value == null)
                {
                    continue;
                }

                decimal suma = Convert.ToDecimal(row.Cells["Suma"].Value);

                if (suma > 500)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}