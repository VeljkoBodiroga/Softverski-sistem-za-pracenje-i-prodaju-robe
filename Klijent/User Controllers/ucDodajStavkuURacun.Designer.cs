namespace Klijent.User_Controllers
{
    partial class ucDodajStavkuURacun
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
            TxtNaziv = new TextBox();
            TxtKolicina = new TextBox();
            TxtCena = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            DgvSportskaOprema = new DataGridView();
            Label4 = new Label();
            BtnDodajStavku = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvSportskaOprema).BeginInit();
            SuspendLayout();
            // 
            // txtNaziv
            // 
            TxtNaziv.BorderStyle = BorderStyle.FixedSingle;
            TxtNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNaziv.Location = new Point(138, 44);
            TxtNaziv.Name = "txtNaziv";
            TxtNaziv.Size = new Size(175, 29);
            TxtNaziv.TabIndex = 0;
            // 
            // txtKolicina
            // 
            TxtKolicina.BorderStyle = BorderStyle.FixedSingle;
            TxtKolicina.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtKolicina.Location = new Point(138, 96);
            TxtKolicina.Name = "txtKolicina";
            TxtKolicina.Size = new Size(175, 29);
            TxtKolicina.TabIndex = 1;
            // 
            // txtCena
            // 
            TxtCena.BorderStyle = BorderStyle.FixedSingle;
            TxtCena.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCena.Location = new Point(138, 150);
            TxtCena.Name = "txtCena";
            TxtCena.Size = new Size(175, 29);
            TxtCena.TabIndex = 2;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(32, 47);
            Label1.Name = "label1";
            Label1.Size = new Size(103, 23);
            Label1.TabIndex = 3;
            Label1.Text = "Naziv stavke";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(32, 99);
            Label2.Name = "label2";
            Label2.Size = new Size(70, 23);
            Label2.TabIndex = 4;
            Label2.Text = "Količina";
            // 
            // label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(32, 153);
            Label3.Name = "label3";
            Label3.Size = new Size(48, 23);
            Label3.TabIndex = 5;
            Label3.Text = "Cena";
            // 
            // dgvSportskaOprema
            // 
            DgvSportskaOprema.ReadOnly = true;
            DgvSportskaOprema.BackgroundColor = Color.White;
            DgvSportskaOprema.BorderStyle = BorderStyle.FixedSingle;
            DgvSportskaOprema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSportskaOprema.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            DgvSportskaOprema.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvSportskaOprema.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DgvSportskaOprema.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DgvSportskaOprema.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            DgvSportskaOprema.DefaultCellStyle.SelectionForeColor = Color.Black;
            DgvSportskaOprema.EnableHeadersVisualStyles = false;
            DgvSportskaOprema.GridColor = Color.FromArgb(230, 230, 230);
            DgvSportskaOprema.RowHeadersVisible = false;
            DgvSportskaOprema.Location = new Point(35, 233);
            DgvSportskaOprema.Name = "dgvSportskaOprema";
            DgvSportskaOprema.RowHeadersWidth = 51;
            DgvSportskaOprema.Size = new Size(489, 135);
            DgvSportskaOprema.TabIndex = 6;
            // 
            // label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(64, 64, 64);
            Label4.Location = new Point(35, 208);
            Label4.Name = "label4";
            Label4.Size = new Size(196, 23);
            Label4.TabIndex = 7;
            Label4.Text = "Izaberi sportsku opremu:";
            // 
            // btnDodajStavku
            // 
            BtnDodajStavku.BackColor = Color.FromArgb(0, 120, 215);
            BtnDodajStavku.FlatAppearance.BorderSize = 0;
            BtnDodajStavku.FlatStyle = FlatStyle.Flat;
            BtnDodajStavku.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDodajStavku.ForeColor = Color.White;
            BtnDodajStavku.Location = new Point(365, 77);
            BtnDodajStavku.Name = "btnDodajStavku";
            BtnDodajStavku.Size = new Size(138, 65);
            BtnDodajStavku.TabIndex = 8;
            BtnDodajStavku.Text = "Dodaj stavku";
            BtnDodajStavku.UseVisualStyleBackColor = false;
            // 
            // ucDodajStavkuURacun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDodajStavku);
            Controls.Add(Label4);
            Controls.Add(DgvSportskaOprema);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TxtCena);
            Controls.Add(TxtKolicina);
            Controls.Add(TxtNaziv);
            Name = "ucDodajStavkuURacun";
            Size = new Size(555, 398);
            ((System.ComponentModel.ISupportInitialize)DgvSportskaOprema).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaziv;
        private TextBox txtKolicina;
        private TextBox txtCena;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvSportskaOprema;
        private Label label4;
        private Button btnDodajStavku;

        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DgvSportskaOprema { get => dgvSportskaOprema; set => dgvSportskaOprema = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
    }
}
