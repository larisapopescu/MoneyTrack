using System.Text.Json;

namespace MoneyTrack
{
    public partial class Login : Form
    {
        string filePath = "users.json";

        public Login()
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
                    Bugetsibutoane form3 = new Bugetsibutoane(user.Budget, user.Currency);
                    form3.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Username sau parola gresita!");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
        }
    }
}