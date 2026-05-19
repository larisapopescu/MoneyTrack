using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MoneyTrack
{
    public partial class Bugetsibutoane : Form
    {
        string currentUsername;

        decimal currentBudget;
        string currentCurrency;

        public Bugetsibutoane(string budget, string currency, string username)
        {
            InitializeComponent();

            currentUsername = username;

            currentBudget = decimal.Parse(budget);
            currentCurrency = currency;

            labelBuget.Text = "BUGET: " + currentBudget + " " + currentCurrency;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cheltuieli form = new Cheltuieli(currentUsername);

            if (form.ShowDialog() == DialogResult.OK)
            {
                currentBudget -= form.LastExpenseAmount;

                labelBuget.Text = "BUGET: " + currentBudget + " " + currentCurrency;
            }
        }
    }
}