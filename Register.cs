using System.Text.Json;

namespace MoneyTrack
{
    public partial class Register : Form
    {
        string filePath = "users.json";

        bool isProcessing = false;

        public Register()
        {
            InitializeComponent();

            textBox1.UseSystemPasswordChar = false;
            textBox1.PasswordChar = '\0';

            registernow.Click -= registernow_Click;
            registernow.Click += registernow_Click;
        }

        private void registernow_Click(object sender, EventArgs e)
        {
            if (isProcessing == true)
            {
                return;
            }

            isProcessing = true;

            string username = registerusername.Text;
            string password = textBox1.Text;
            string budget = textBox2.Text;
            string currency = comboBox1.Text;

            if (username == "" || password == "" || budget == "" || currency == "")
            {
                MessageBox.Show("Completeaza toate campurile!");
                isProcessing = false;
                return;
            }

            decimal testBudget;

            if (!decimal.TryParse(budget, out testBudget))
            {
                MessageBox.Show("Bugetul trebuie sa fie numar!");
                isProcessing = false;
                return;
            }

            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                if (json != "")
                {
                    users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
                }
            }

            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    MessageBox.Show("Exista deja un cont cu acest username!");
                    isProcessing = false;
                    return;
                }
            }

            User newUser = new User()
            {
                Username = username,
                Password = password,
                Budget = budget,
                Currency = currency
            };

            users.Add(newUser);

            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, newJson);

            MessageBox.Show("Cont creat cu succes!");

            this.Close();
        }
    }
}