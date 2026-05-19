namespace MoneyTrack
{
    partial class TotalCheltuieli
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(36, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 474);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-41, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(569, 471);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(571, 88);
            button1.Name = "button1";
            button1.Size = new Size(218, 57);
            button1.TabIndex = 2;
            button1.Text = "Editare sau stergere";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(571, 194);
            button2.Name = "button2";
            button2.Size = new Size(218, 57);
            button2.TabIndex = 3;
            button2.Text = "Filtrare cheltuieli";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(571, 296);
            button3.Name = "button3";
            button3.Size = new Size(218, 57);
            button3.TabIndex = 4;
            button3.Text = "Cautare cheltuieli";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(820, 433);
            button4.Name = "button4";
            button4.Size = new Size(109, 29);
            button4.TabIndex = 5;
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = true;
            // 
            // TotalCheltuieli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(button4);
            Controls.Add(panel1);
            Name = "TotalCheltuieli";
            Text = "TotalCheltuieli";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}