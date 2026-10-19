using System.Windows.Forms;

namespace Klijent.User_Controllers
{
    partial class ucPrikaziListuRacuna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvListaRacuna = new DataGridView();
            BtnVratise = new Button();
            BtnPromeniRacun = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvListaRacuna).BeginInit();
            SuspendLayout();
            // 
            // dgvListaRacuna
            // 
            DgvListaRacuna.ReadOnly = true;
            DgvListaRacuna.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvListaRacuna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvListaRacuna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvListaRacuna.DefaultCellStyle = dataGridViewCellStyle2;
            DgvListaRacuna.EnableHeadersVisualStyles = false;
            DgvListaRacuna.GridColor = Color.FromArgb(230, 230, 230);
            DgvListaRacuna.Location = new Point(51, 57);
            DgvListaRacuna.Name = "dgvListaRacuna";
            DgvListaRacuna.RowHeadersVisible = false;
            DgvListaRacuna.RowHeadersWidth = 51;
            DgvListaRacuna.Size = new Size(667, 363);
            DgvListaRacuna.TabIndex = 0;
            // 
            // btnVratise
            // 
            BtnVratise.BackColor = Color.FromArgb(0, 120, 215);
            BtnVratise.FlatAppearance.BorderSize = 0;
            BtnVratise.FlatStyle = FlatStyle.Flat;
            BtnVratise.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVratise.ForeColor = Color.White;
            BtnVratise.Location = new Point(82, 440);
            BtnVratise.Name = "btnVratise";
            BtnVratise.Size = new Size(269, 47);
            BtnVratise.TabIndex = 1;
            BtnVratise.Text = "Vrati se na pretragu";
            BtnVratise.UseVisualStyleBackColor = false;
            // 
            // btnPromeniRacun
            // 
            BtnPromeniRacun.BackColor = Color.FromArgb(0, 120, 215);
            BtnPromeniRacun.FlatAppearance.BorderSize = 0;
            BtnPromeniRacun.FlatStyle = FlatStyle.Flat;
            BtnPromeniRacun.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPromeniRacun.ForeColor = Color.White;
            BtnPromeniRacun.Location = new Point(431, 440);
            BtnPromeniRacun.Name = "btnPromeniRacun";
            BtnPromeniRacun.Size = new Size(269, 47);
            BtnPromeniRacun.TabIndex = 2;
            BtnPromeniRacun.Text = "Promeni račun";
            BtnPromeniRacun.UseVisualStyleBackColor = false;
            // 
            // ucPrikaziListuRacuna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnPromeniRacun);
            Controls.Add(BtnVratise);
            Controls.Add(DgvListaRacuna);
            Name = "ucPrikaziListuRacuna";
            Size = new Size(770, 529);
            ((System.ComponentModel.ISupportInitialize)DgvListaRacuna).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaRacuna;
        private Button btnVratise;
        private Button btnPromeniRacun;

        public DataGridView DgvListaRacuna { get => dgvListaRacuna; set => dgvListaRacuna = value; }
        public Button BtnVratise { get => btnVratise; set => btnVratise = value; }
        public Button BtnPromeniRacun { get => btnPromeniRacun; set => btnPromeniRacun = value; }
    }
}
