namespace Klijent.User_Controllers
{
    partial class ucPrijavljeniProdavac
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
            dgvStrucneSpreme = new DataGridView();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            TxtIme = new TextBox();
            TxtPrezime = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvStrucneSpreme).BeginInit();
            SuspendLayout();
            // 
            // dgvStrucneSpreme
            // 
            DgvStrucneSpreme.ReadOnly=true;
            DgvStrucneSpreme.BackgroundColor = Color.White;
            DgvStrucneSpreme.BorderStyle = BorderStyle.FixedSingle;
            DgvStrucneSpreme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvStrucneSpreme.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            DgvStrucneSpreme.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvStrucneSpreme.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DgvStrucneSpreme.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DgvStrucneSpreme.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            DgvStrucneSpreme.DefaultCellStyle.SelectionForeColor = Color.Black;
            DgvStrucneSpreme.EnableHeadersVisualStyles = false;
            DgvStrucneSpreme.GridColor = Color.FromArgb(230, 230, 230);
            DgvStrucneSpreme.RowHeadersVisible = false;
            DgvStrucneSpreme.Location = new Point(77, 185);
            DgvStrucneSpreme.Name = "dgvStrucneSpreme";
            DgvStrucneSpreme.RowHeadersWidth = 51;
            DgvStrucneSpreme.Size = new Size(433, 131);
            DgvStrucneSpreme.TabIndex = 0;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(77, 67);
            Label1.Name = "label1";
            Label1.Size = new Size(34, 23);
            Label1.TabIndex = 1;
            Label1.Text = "Ime";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(77, 112);
            Label2.Name = "label2";
            Label2.Size = new Size(62, 23);
            Label2.TabIndex = 2;
            Label2.Text = "Prezime";
            // 
            // label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(77, 162);
            Label3.Name = "label3";
            Label3.Size = new Size(177, 23);
            Label3.TabIndex = 3;
            Label3.Text = "Strucne spreme prodavca";
            // 
            // txtIme
            // 
            TxtIme.BorderStyle = BorderStyle.FixedSingle;
            TxtIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIme.Location = new Point(161, 64);
            TxtIme.Name = "txtIme";
            TxtIme.Size = new Size(218, 29);
            TxtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            TxtPrezime.BorderStyle = BorderStyle.FixedSingle;
            TxtPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrezime.Location = new Point(161, 109);
            TxtPrezime.Name = "txtPrezime";
            TxtPrezime.Size = new Size(218, 29);
            TxtPrezime.TabIndex = 5;
            // 
            // ucPrijavljeniProdavac
            // 
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStrucneSpreme);
            Name = "ucPrijavljeniProdavac";
            Size = new Size(584, 386);
            ((System.ComponentModel.ISupportInitialize)DgvStrucneSpreme).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion




        private DataGridView dgvStrucneSpreme;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIme;
        private TextBox txtPrezime;

        public DataGridView DgvStrucneSpreme { get => dgvStrucneSpreme; set => dgvStrucneSpreme = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
    }
}
