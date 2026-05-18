namespace MoneyTrack
{
    partial class Form3
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
            labelBuget = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelBuget
            // 
            labelBuget.AutoSize = true;
            labelBuget.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBuget.Location = new Point(25, 40);
            labelBuget.Name = "labelBuget";
            labelBuget.Size = new Size(120, 35);
            labelBuget.TabIndex = 3;
            labelBuget.Text = "Buget:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(labelBuget);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(117, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 476);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(154, 370);
            button3.Name = "button3";
            button3.Size = new Size(378, 67);
            button3.TabIndex = 6;
            button3.Text = "Exporta datele";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(154, 259);
            button2.Name = "button2";
            button2.Size = new Size(378, 67);
            button2.TabIndex = 5;
            button2.Text = "Adaugare cheltuieli";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(154, 142);
            button1.Name = "button1";
            button1.Size = new Size(378, 67);
            button1.TabIndex = 0;
            button1.Text = "Total cheltuieli";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "MoneyTrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelBuget;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}