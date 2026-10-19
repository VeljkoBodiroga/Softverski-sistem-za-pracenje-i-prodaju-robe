namespace Klijent.User_Controllers
{
    partial class ucKreirajKupca
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
            TxtIme = new TextBox();
            TxtPrezime = new TextBox();
            TxtBrojTelefona = new TextBox();
            BtnKreirajKupca = new Button();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            CmbMesto = new ComboBox();
            Label4 = new Label();
            SuspendLayout();
            // 
            // txtIme
            // 
            TxtIme.BorderStyle = BorderStyle.FixedSingle;
            TxtIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIme.Location = new Point(156, 63);
            TxtIme.Name = "txtIme";
            TxtIme.Size = new Size(241, 29);
            TxtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            TxtPrezime.BorderStyle = BorderStyle.FixedSingle;
            TxtPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrezime.Location = new Point(156, 130);
            TxtPrezime.Name = "txtPrezime";
            TxtPrezime.Size = new Size(241, 29);
            TxtPrezime.TabIndex = 1;
            // 
            // txtBrojTelefona
            // 
            TxtBrojTelefona.BorderStyle = BorderStyle.FixedSingle;
            TxtBrojTelefona.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBrojTelefona.Location = new Point(156, 205);
            TxtBrojTelefona.Name = "txtBrojTelefona";
            TxtBrojTelefona.Size = new Size(241, 29);
            TxtBrojTelefona.TabIndex = 2;
            // 
            // btnKreirajKupca
            // 
            BtnKreirajKupca.BackColor = Color.FromArgb(0, 120, 215);
            BtnKreirajKupca.FlatAppearance.BorderSize = 0;
            BtnKreirajKupca.FlatStyle = FlatStyle.Flat;
            BtnKreirajKupca.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKreirajKupca.ForeColor = Color.White;
            BtnKreirajKupca.Location = new Point(126, 335);
            BtnKreirajKupca.Name = "btnKreirajKupca";
            BtnKreirajKupca.Size = new Size(299, 39);
            BtnKreirajKupca.TabIndex = 3;
            BtnKreirajKupca.Text = "Kreiraj kupca";
            BtnKreirajKupca.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(156, 38);
            Label1.Name = "label1";
            Label1.Size = new Size(34, 23);
            Label1.TabIndex = 4;
            Label1.Text = "Ime";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(156, 105);
            Label2.Name = "label2";
            Label2.Size = new Size(62, 23);
            Label2.TabIndex = 5;
            Label2.Text = "Prezime";
            // 
            // label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(156, 180);
            Label3.Name = "label3";
            Label3.Size = new Size(95, 23);
            Label3.TabIndex = 6;
            Label3.Text = "Broj telefona";
            // 
            // cmbMesto
            // 
            CmbMesto.FlatStyle = FlatStyle.Flat;
            CmbMesto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbMesto.FormattingEnabled = true;
            CmbMesto.Location = new Point(156, 271);
            CmbMesto.Name = "cmbMesto";
            CmbMesto.Size = new Size(241, 30);
            CmbMesto.TabIndex = 7;
            // 
            // label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(64, 64, 64);
            Label4.Location = new Point(156, 246);
            Label4.Name = "label4";
            Label4.Size = new Size(50, 23);
            Label4.TabIndex = 8;
            Label4.Text = "Mesto";
            // 
            // KreirajKupca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label4);
            Controls.Add(CmbMesto);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(BtnKreirajKupca);
            Controls.Add(TxtBrojTelefona);
            Controls.Add(TxtPrezime);
            Controls.Add(TxtIme);
            Name = "KreirajKupca";
            Size = new Size(550, 418);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtBrojTelefona;
        private Button btnKreirajKupca;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMesto;
        private Label label4;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtBrojTelefona { get => txtBrojTelefona; set => txtBrojTelefona = value; }
        public Button BtnKreirajKupca { get => btnKreirajKupca; set => btnKreirajKupca = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox CmbMesto { get => cmbMesto; set => cmbMesto = value; }
        public Label Label4 { get => label4; set => label4 = value; }
    }
}
