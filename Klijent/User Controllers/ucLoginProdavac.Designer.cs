
namespace Klijent.User_Controllers
{
    partial class ucFrmLoginProdavac
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
            BtnLogin = new Button();
            TxtKorisnickoIme = new TextBox();
            TxtSifra = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(0, 120, 215);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(124, 236);
            BtnLogin.Name = "btnLogin";
            BtnLogin.Size = new Size(313, 48);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Uloguj se";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // txtKorisnickoIme
            // 
            TxtKorisnickoIme.BorderStyle = BorderStyle.FixedSingle;
            TxtKorisnickoIme.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtKorisnickoIme.Location = new Point(124, 104);
            TxtKorisnickoIme.Name = "txtKorisnickoIme";
            TxtKorisnickoIme.Size = new Size(313, 32);
            TxtKorisnickoIme.TabIndex = 1;
            // 
            // txtSifra
            // 
            TxtSifra.BorderStyle = BorderStyle.FixedSingle;
            TxtSifra.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSifra.Location = new Point(124, 179);
            TxtSifra.Name = "txtSifra";
            TxtSifra.PasswordChar = '•';
            TxtSifra.Size = new Size(313, 32);
            TxtSifra.TabIndex = 2;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(124, 75);
            Label1.Name = "label1";
            Label1.Size = new Size(124, 23);
            Label1.TabIndex = 3;
            Label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(124, 150);
            Label2.Name = "label2";
            Label2.Size = new Size(47, 23);
            Label2.TabIndex = 4;
            Label2.Text = "Šifra:";
            // 
            // ucFrmLoginProdavac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TxtSifra);
            Controls.Add(TxtKorisnickoIme);
            Controls.Add(BtnLogin);
            Name = "ucFrmLoginProdavac";
            Size = new Size(558, 382);
            ResumeLayout(false);
            PerformLayout();
        }

        //private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private Button btnLogin;
        private TextBox txtKorisnickoIme;
        private TextBox txtSifra;
        private Label label1;
        private Label label2;

        public Button BtnLogin { get => btnLogin; set => btnLogin = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
    }
}
