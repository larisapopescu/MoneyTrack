using System.Text.Json;

namespace MoneyTrack
{
    public partial class StatisticiGrafic : Form
    {
        string currentUsername;
        string expensesPath = "expenses.json";

        List<Expense> expenses = new List<Expense>();

        public StatisticiGrafic(string username)
        {
            InitializeComponent();

            currentUsername = username;

            buttonReturn.Click += buttonReturn_Click;
            panelGrafic.Paint += panelGrafic_Paint;

            AfiseazaStatisticiSiGrafic();
        }

        private void AfiseazaStatisticiSiGrafic()
        {
            expenses = LoadExpenses()
                .Where(x => x.Username == currentUsername)
                .ToList();

            decimal total = expenses.Sum(x => x.Amount);
            int numar = expenses.Count;
            decimal maxim = numar > 0 ? expenses.Max(x => x.Amount) : 0;
            decimal medie = numar > 0 ? expenses.Average(x => x.Amount) : 0;

            labelTotal.Text = "Total cheltuieli: " + total + " lei";
            labelNumar.Text = "Numar cheltuieli: " + numar;
            labelMaxim.Text = "Cea mai mare cheltuiala: " + maxim + " lei";
            labelMedie.Text = "Media cheltuielilor: " + Math.Round(medie, 2) + " lei";

            panelGrafic.Invalidate();
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            var cheltuieliPeCategorii = expenses
                .GroupBy(x => x.Category)
                .Select(grup => new
                {
                    Categorie = grup.Key,
                    Total = grup.Sum(x => x.Amount)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            if (cheltuieliPeCategorii.Count == 0)
            {
                g.DrawString(
                    "Nu exista cheltuieli pentru grafic.",
                    new Font("Arial", 12, FontStyle.Bold),
                    Brushes.Black,
                    20,
                    20
                );

                return;
            }

            decimal totalGeneral = cheltuieliPeCategorii.Sum(x => x.Total);

            Rectangle pieRect = new Rectangle(30, 30, 260, 260);

            Color[] culori =
            {
                Color.SteelBlue,
                Color.Orange,
                Color.MediumSeaGreen,
                Color.IndianRed,
                Color.MediumPurple,
                Color.Goldenrod,
                Color.DeepPink,
                Color.Teal
            };

            float startAngle = 0;

            for (int i = 0; i < cheltuieliPeCategorii.Count; i++)
            {
                var item = cheltuieliPeCategorii[i];

                float sweepAngle = (float)(item.Total / totalGeneral * 360);

                using (SolidBrush brush = new SolidBrush(culori[i % culori.Length]))
                {
                    g.FillPie(brush, pieRect, startAngle, sweepAngle);
                }

                g.DrawPie(Pens.White, pieRect, startAngle, sweepAngle);

                startAngle += sweepAngle;
            }

            Font font = new Font("Arial", 10, FontStyle.Regular);
            Font fontBold = new Font("Arial", 10, FontStyle.Bold);

            int legendX = 330;
            int legendY = 35;

            for (int i = 0; i < cheltuieliPeCategorii.Count; i++)
            {
                var item = cheltuieliPeCategorii[i];

                decimal procent = item.Total / totalGeneral * 100;

                using (SolidBrush brush = new SolidBrush(culori[i % culori.Length]))
                {
                    g.FillRectangle(brush, legendX, legendY, 18, 18);
                }

                g.DrawRectangle(Pens.Black, legendX, legendY, 18, 18);

                string textLegenda =
                    item.Categorie + " - " +
                    item.Total + " lei (" +
                    Math.Round(procent, 2) + "%)";

                g.DrawString(textLegenda, font, Brushes.Black, legendX + 30, legendY - 2);

                legendY += 30;
            }

            g.DrawString(
                "Cheltuieli pe categorii",
                fontBold,
                Brushes.Black,
                30,
                305
            );
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}