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

            LoginButton.Click -= Login_Click;
            LoginButton.Click += Login_Click;

            Register.Click -= Register_Click;
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

            if (json == "")
            {
                MessageBox.Show("Nu exista conturi create! Apasa Register.");
                return;
            }

            List<User> users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Bugetsibutoane form = new Bugetsibutoane(user.Budget, user.Currency, user.Username);
                    form.Show();

                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Username sau parola gresita!");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.ShowDialog();
        }
    }
}