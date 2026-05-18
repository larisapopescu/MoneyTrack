using System.Text.Json;

namespace MoneyTrack
{
    public partial class Form1 : Form
    {
        string filePath = "users.json";

        public Form1()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;

            Login.Click += Login_Click;
            Register.Click += Register_Click;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Completeaza username-ul si parola!");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Nu exista conturi create! Apasa Register.");
                return;
            }

            string json = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Form3 form3 = new Form3(user.Budget, user.Currency);
                    form3.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Username sau parola gresita!");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}