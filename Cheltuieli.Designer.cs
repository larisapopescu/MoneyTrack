namespace MoneyTrack
{
    partial class Cheltuieli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBoxCategorie = new ComboBox();
            textBoxDescriere = new TextBox();
            label1 = new Label();
            textBoxSuma = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBoxCategorie);
            panel1.Controls.Add(textBoxDescriere);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxSuma);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.Khaki;
            panel1.Location = new Point(162, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 480);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 295);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 9;
            label5.Text = "Alegeti categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 228);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 8;
            label4.Text = "Introduceti data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 171);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 7;
            label3.Text = "Introduceti descrierea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Introduceti suma";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(280, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBoxCategorie
            // 
            comboBoxCategorie.FormattingEnabled = true;
            comboBoxCategorie.Items.AddRange(new object[] { "Sanatate", "Timp liber", "Casa", "Educatie", "Cadouri", "Produse alimentare", "Iesit in oras" });
            comboBoxCategorie.Location = new Point(167, 292);
            comboBoxCategorie.Name = "comboBoxCategorie";
            comboBoxCategorie.Size = new Size(280, 28);
            comboBoxCategorie.TabIndex = 4;
            // 
            // textBoxDescriere
            // 
            textBoxDescriere.Location = new Point(167, 164);
            textBoxDescriere.Name = "textBoxDescriere";
            textBoxDescriere.Size = new Size(285, 27);
            textBoxDescriere.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(108, 28);
            label1.Name = "label1";
            label1.Size = new Size(418, 33);
            label1.TabIndex = 2;
            label1.Text = "Adaugarea unei cheltuieli:";
            // 
            // textBoxSuma
            // 
            textBoxSuma.Location = new Point(167, 95);
            textBoxSuma.Name = "textBoxSuma";
            textBoxSuma.Size = new Size(285, 27);
            textBoxSuma.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(156, 351);
            button1.Name = "button1";
            button1.Size = new Size(309, 91);
            button1.TabIndex = 0;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cheltuieli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(panel1);
            Name = "Cheltuieli";
            Text = "Moneytrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxCategorie;
        private TextBox textBoxDescriere;
        private Label label1;
        private TextBox textBoxSuma;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}