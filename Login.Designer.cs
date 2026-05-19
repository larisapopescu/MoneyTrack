namespace MoneyTrack
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Register = new Button();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();

            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(Register);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(480, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 473);
            panel1.TabIndex = 0;

            Register.BackColor = Color.DarkSeaGreen;
            Register.Font = new Font("Stencil", 16.2F);
            Register.ForeColor = Color.Transparent;
            Register.Location = new Point(96, 349);
            Register.Name = "Register";
            Register.Size = new Size(247, 93);
            Register.TabIndex = 7;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;

            label5.AutoSize = true;
            label5.Location = new Point(25, 316);
            label5.Name = "label5";
            label5.Size = new Size(240, 20);
            label5.TabIndex = 3;
            label5.Text = "Nu ai cont? Inregistreaza-te acum!!";

            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(35, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 180);
            panel2.TabIndex = 2;

            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(67, 103);
            label4.Name = "label4";
            label4.Size = new Size(266, 24);
            label4.TabIndex = 1;
            label4.Text = "controleaza-ti viitorul";

            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(80, 54);
            label3.Name = "label3";
            label3.Size = new Size(228, 24);
            label3.TabIndex = 0;
            label3.Text = "Controleaza-ti banii";

            Username.Location = new Point(127, 160);
            Username.Name = "Username";
            Username.Size = new Size(230, 27);
            Username.TabIndex = 2;

            Password.Location = new Point(127, 220);
            Password.Name = "Password";
            Password.Size = new Size(230, 27);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;

            label1.AutoSize = true;
            label1.Location = new Point(12, 164);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";

            label2.AutoSize = true;
            label2.Location = new Point(12, 223);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";

            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            LoginButton.BackColor = Color.DarkSeaGreen;
            LoginButton.Font = new Font("Stencil", 16.2F);
            LoginButton.ForeColor = Color.Transparent;
            LoginButton.Location = new Point(110, 350);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(247, 93);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;

            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(93, 162);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;

            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(93, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "MoneyTrack";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button LoginButton;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button Register;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}