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
            buttonDelete = new Button();
            buttonReturn = new Button();
            buttonReset = new Button();
            buttonStatisticiGrafic = new Button();
            buttonSearch = new Button();
            buttonFilter = new Button();
            buttonEdit = new Button();
            dataGridViewExpenses = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonReturn);
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonStatisticiGrafic);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(buttonFilter);
            panel1.Controls.Add(buttonEdit);
            panel1.Controls.Add(dataGridViewExpenses);
            panel1.Location = new Point(36, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 474);
            panel1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(571, 86);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(203, 45);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Stergere";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReturn.Location = new Point(627, 432);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(109, 29);
            buttonReturn.TabIndex = 5;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(571, 358);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(203, 52);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Resetare";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonStatisticiGrafic
            // 
            buttonStatisticiGrafic.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStatisticiGrafic.Location = new Point(571, 286);
            buttonStatisticiGrafic.Name = "buttonStatisticiGrafic";
            buttonStatisticiGrafic.Size = new Size(203, 56);
            buttonStatisticiGrafic.TabIndex = 5;
            buttonStatisticiGrafic.Text = "Statistici si Grafic";
            buttonStatisticiGrafic.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(571, 218);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(203, 52);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Cautare cheltuieli";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            buttonFilter.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFilter.Location = new Point(571, 149);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(203, 50);
            buttonFilter.TabIndex = 3;
            buttonFilter.Text = "Filtrare cheltuieli";
            buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(571, 27);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(203, 44);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Editare ";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenses.Location = new Point(-41, 0);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.Size = new Size(569, 471);
            dataGridViewExpenses.TabIndex = 1;
            // 
            // TotalCheltuieli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 474);
            Controls.Add(panel1);
            Name = "TotalCheltuieli";
            Text = "TotalCheltuieli";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewExpenses;
        private Button buttonEdit;
        private Button buttonSearch;
        private Button buttonFilter;
        private Button buttonReturn;
        private Button buttonStatisticiGrafic;
        private Button buttonDelete;
        private Button buttonReset;
    }
}