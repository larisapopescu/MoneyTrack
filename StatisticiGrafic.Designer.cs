namespace MoneyTrack
{
    partial class StatisticiGrafic
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
            labelMedie = new Label();
            labelMaxim = new Label();
            labelNumar = new Label();
            labelTotal = new Label();
            buttonReturn = new Button();
            panelGrafic = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(labelMedie);
            panel1.Controls.Add(labelMaxim);
            panel1.Controls.Add(labelNumar);
            panel1.Controls.Add(labelTotal);
            panel1.Location = new Point(137, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 474);
            panel1.TabIndex = 0;
            // 
            // labelMedie
            // 
            labelMedie.AutoSize = true;
            labelMedie.Location = new Point(3, 84);
            labelMedie.Name = "labelMedie";
            labelMedie.Size = new Size(50, 20);
            labelMedie.TabIndex = 3;
            labelMedie.Text = "label4";
            // 
            // labelMaxim
            // 
            labelMaxim.AutoSize = true;
            labelMaxim.Location = new Point(3, 26);
            labelMaxim.Name = "labelMaxim";
            labelMaxim.Size = new Size(50, 20);
            labelMaxim.TabIndex = 2;
            labelMaxim.Text = "label3";
            // 
            // labelNumar
            // 
            labelNumar.AutoSize = true;
            labelNumar.Location = new Point(299, 93);
            labelNumar.Name = "labelNumar";
            labelNumar.Size = new Size(50, 20);
            labelNumar.TabIndex = 1;
            labelNumar.Text = "label2";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(299, 26);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(50, 20);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "label1";
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReturn.Location = new Point(801, 412);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(128, 50);
            buttonReturn.TabIndex = 4;
            buttonReturn.Text = "return";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // panelGrafic
            // 
            panelGrafic.BackColor = Color.White;
            panelGrafic.Location = new Point(137, 196);
            panelGrafic.Name = "panelGrafic";
            panelGrafic.Size = new Size(645, 277);
            panelGrafic.TabIndex = 4;
            // 
            // StatisticiGrafic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(buttonReturn);
            Controls.Add(panelGrafic);
            Controls.Add(panel1);
            Name = "StatisticiGrafic";
            Text = "MoneyTrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelMedie;
        private Label labelMaxim;
        private Label labelNumar;
        private Label labelTotal;
        private Button buttonReturn;
        private Panel panelGrafic;
    }
}