namespace Klijent.User_Controllers
{
    partial class ucDodajStrucnuSpremu
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
            TxtNivo = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            BtnDodajStrucnuSpremu = new Button();
            SuspendLayout();
            // 
            // txtNaziv
            // 
            TxtNaziv.BorderStyle = BorderStyle.FixedSingle;
            TxtNaziv.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNaziv.Location = new Point(108, 74);
            TxtNaziv.Name = "txtNaziv";
            TxtNaziv.Size = new Size(191, 30);
            TxtNaziv.TabIndex = 0;
            // 
            // txtNivo
            // 
            TxtNivo.BorderStyle = BorderStyle.FixedSingle;
            TxtNivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNivo.Location = new Point(108, 141);
            TxtNivo.Name = "txtNivo";
            TxtNivo.Size = new Size(191, 30);
            TxtNivo.TabIndex = 1;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(108, 49);
            Label1.Name = "label1";
            Label1.Size = new Size(52, 23);
            Label1.TabIndex = 2;
            Label1.Text = "Naziv";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(108, 116);
            Label2.Name = "label2";
            Label2.Size = new Size(45, 23);
            Label2.TabIndex = 3;
            Label2.Text = "Nivo";
            // 
            // btnDodajStrucnuSpremu
            // 
            BtnDodajStrucnuSpremu.BackColor = Color.FromArgb(0, 120, 215);
            BtnDodajStrucnuSpremu.FlatAppearance.BorderSize = 0;
            BtnDodajStrucnuSpremu.FlatStyle = FlatStyle.Flat;
            BtnDodajStrucnuSpremu.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDodajStrucnuSpremu.ForeColor = Color.White;
            BtnDodajStrucnuSpremu.Location = new Point(99, 227);
            BtnDodajStrucnuSpremu.Name = "btnDodajStrucnuSpremu";
            BtnDodajStrucnuSpremu.Size = new Size(209, 37);
            BtnDodajStrucnuSpremu.TabIndex = 4;
            BtnDodajStrucnuSpremu.Text = "Dodaj stručnu spremu";
            BtnDodajStrucnuSpremu.UseVisualStyleBackColor = false;
            // 
            // ucDodajStrucnuSpremu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDodajStrucnuSpremu);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TxtNivo);
            Controls.Add(TxtNaziv);
            Name = "ucDodajStrucnuSpremu";
            Size = new Size(405, 321);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaziv;
        private TextBox txtNivo;
        private Label label1;
        private Label label2;
        private Button btnDodajStrucnuSpremu;

        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtNivo { get => txtNivo; set => txtNivo = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnDodajStrucnuSpremu { get => btnDodajStrucnuSpremu; set => btnDodajStrucnuSpremu = value; }
    }
}
