namespace MoneyTrack
{
    partial class Register
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
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            registernow = new Button();
            textBox1 = new TextBox();
            registerusername = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(registernow);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(registerusername);
            panel1.Location = new Point(205, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 469);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 236);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 10;
            label5.Text = "Introdu bugetul";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 236);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 298);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 8;
            label4.Text = "Alege moneda";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lei (RON)", "USD ($)", "Euro (€)" });
            comboBox1.Location = new Point(132, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 28);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 33);
            label1.Name = "label1";
            label1.Size = new Size(243, 27);
            label1.TabIndex = 4;
            label1.Text = "Creeaza-ti contul!!";
            // 
            // registernow
            // 
            registernow.BackColor = Color.DarkSeaGreen;
            registernow.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registernow.ForeColor = Color.Transparent;
            registernow.Location = new Point(116, 355);
            registernow.Name = "registernow";
            registernow.Size = new Size(297, 105);
            registernow.TabIndex = 3;
            registernow.Text = "Register";
            registernow.UseVisualStyleBackColor = false;
            registernow.Click += registernow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 1;
            // 
            // registerusername
            // 
            registerusername.Location = new Point(128, 88);
            registerusername.Name = "registerusername";
            registerusername.Size = new Size(291, 27);
            registerusername.TabIndex = 0;
            textBox1.UseSystemPasswordChar = false;
            textBox1.PasswordChar = '\0';
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "MoneyTrack";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button registernow;
        private TextBox textBox1;
        private TextBox registerusername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
    }
}