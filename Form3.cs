namespace MoneyTrack
{
    public partial class Form3 : Form
    {
        public Form3(string budget, string currency)
        {
            InitializeComponent();

            labelBuget.Text = "BUGET: " + budget + " " + currency;
        }
    }
}