namespace MoneyTrack
{
    public partial class Bugetsibutoane : Form
    {
        public Bugetsibutoane(string budget, string currency)
        {
            InitializeComponent();

            labelBuget.Text = "BUGET: " + budget + " " + currency;
        }
    }
}