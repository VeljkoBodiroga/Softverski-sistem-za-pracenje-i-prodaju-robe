namespace Klijent.User_Controllers
{
    partial class ucPromeniKupca
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
            TxtBrTelefona = new TextBox();
            CmbMesto = new ComboBox();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            BtnPromeni = new Button();

            SuspendLayout();

            // 
            // txtIme
            // 
            TxtIme.BorderStyle = BorderStyle.FixedSingle;
            TxtIme.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIme.Location = new Point(246, 76);
            TxtIme.Name = "txtIme";
            TxtIme.Size = new Size(254, 30);
            TxtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            TxtPrezime.BorderStyle = BorderStyle.FixedSingle;
            TxtPrezime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrezime.Location = new Point(246, 137);
            TxtPrezime.Name = "txtPrezime";
            TxtPrezime.Size = new Size(254, 30);
            TxtPrezime.TabIndex = 1;
            // 
            // txtBrTelefona
            // 
            TxtBrTelefona.BorderStyle = BorderStyle.FixedSingle;
            TxtBrTelefona.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBrTelefona.Location = new Point(246, 198);
            TxtBrTelefona.Name = "txtBrTelefona";
            TxtBrTelefona.Size = new Size(254, 30);
            TxtBrTelefona.TabIndex = 2;
            // 
            // cmbMesto
            // 
            CmbMesto.FlatStyle = FlatStyle.Flat;
            CmbMesto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbMesto.FormattingEnabled = true;
            CmbMesto.Location = new Point(246, 263);
            CmbMesto.Name = "cmbMesto";
            CmbMesto.Size = new Size(254, 31);
            CmbMesto.TabIndex = 3;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(129, 79);
            Label1.Name = "label1";
            Label1.Size = new Size(39, 23);
            Label1.TabIndex = 4;
            Label1.Text = "Ime";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(129, 140);
            Label2.Name = "label2";
            Label2.Size = new Size(71, 23);
            Label2.TabIndex = 5;
            Label2.Text = "Prezime";
            // 
            // label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(129, 201);
            Label3.Name = "label3";
            Label3.Size = new Size(107, 23);
            Label3.TabIndex = 6;
            Label3.Text = "Broj telefona";
            // 
            // label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(64, 64, 64);
            Label4.Location = new Point(129, 266);
            Label4.Name = "label4";
            Label4.Size = new Size(57, 23);
            Label4.TabIndex = 7;
            Label4.Text = "Mesto";
            // 
            // btnPromeni
            // 
            BtnPromeni.BackColor = Color.FromArgb(0, 120, 215);
            BtnPromeni.FlatAppearance.BorderSize = 0;
            BtnPromeni.FlatStyle = FlatStyle.Flat;
            BtnPromeni.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPromeni.ForeColor = Color.White;
            BtnPromeni.Location = new Point(176, 331);
            BtnPromeni.Name = "btnPromeni";
            BtnPromeni.Size = new Size(283, 50);
            BtnPromeni.TabIndex = 8;
            BtnPromeni.Text = "Promeni kupca";
            BtnPromeni.UseVisualStyleBackColor = false;
            // 
            // ucPromeniIObrisiKupca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnPromeni);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(CmbMesto);
            Controls.Add(TxtBrTelefona);
            Controls.Add(TxtPrezime);
            Controls.Add(TxtIme);
            Name = "ucPromeniIObrisiKupca";
            Size = new Size(623, 450);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtBrTelefona;
        private ComboBox cmbMesto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPromeni;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtBrTelefona { get => txtBrTelefona; set => txtBrTelefona = value; }
        public ComboBox CmbMesto { get => cmbMesto; set => cmbMesto = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnPromeni { get => btnPromeni; set => btnPromeni = value; }
    }
}
