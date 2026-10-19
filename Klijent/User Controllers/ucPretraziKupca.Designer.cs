using System.Windows.Forms;

namespace Klijent.User_Controllers
{
    partial class ucPretraziKupca
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
            BtnObrisi = new Button();

            TxtImePrezime = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            BtnPretraziPoImenuIPrezimenu = new Button();
            BtnPretraziPoMestu = new Button();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DgvKupci = new DataGridView();
            BtnPrikazOdabranog = new Button();
            CmbMesto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvKupci).BeginInit();
            SuspendLayout();
            // 
            // btnObrisi
            // 
            BtnObrisi.BackColor = Color.FromArgb(196, 43, 28);
            BtnObrisi.FlatAppearance.BorderSize = 0;
            BtnObrisi.FlatStyle = FlatStyle.Flat;
            BtnObrisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnObrisi.ForeColor = Color.White;
            BtnObrisi.Location = new Point(340, 371);
            BtnObrisi.Name = "btnObrisi";
            BtnObrisi.Size = new Size(226, 39);
            BtnObrisi.TabIndex = 0;
            BtnObrisi.Text = "Obriši kupca";
            BtnObrisi.UseVisualStyleBackColor = false;
            // 
            // txtImePrezime
            // 
            TxtImePrezime.BorderStyle = BorderStyle.FixedSingle;
            TxtImePrezime.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtImePrezime.Location = new Point(57, 60);
            TxtImePrezime.Name = "txtImePrezime";
            TxtImePrezime.Size = new Size(265, 30);
            TxtImePrezime.TabIndex = 0;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(57, 34);
            Label1.Name = "label1";
            Label1.Size = new Size(114, 23);
            Label1.TabIndex = 2;
            Label1.Text = "Ime i prezime";
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(57, 95);
            Label2.Name = "label2";
            Label2.Size = new Size(57, 23);
            Label2.TabIndex = 3;
            Label2.Text = "Mesto";
            // 
            // btnPretraziPoImenuIPrezimenu
            // 
            BtnPretraziPoImenuIPrezimenu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretraziPoImenuIPrezimenu.FlatAppearance.BorderSize = 0;
            BtnPretraziPoImenuIPrezimenu.FlatStyle = FlatStyle.Flat;
            BtnPretraziPoImenuIPrezimenu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretraziPoImenuIPrezimenu.ForeColor = Color.White;
            BtnPretraziPoImenuIPrezimenu.Location = new Point(344, 54);
            BtnPretraziPoImenuIPrezimenu.Name = "btnPretraziPoImenuIPrezimenu";
            BtnPretraziPoImenuIPrezimenu.Size = new Size(262, 39);
            BtnPretraziPoImenuIPrezimenu.TabIndex = 4;
            BtnPretraziPoImenuIPrezimenu.Text = "Pretraži po imenu i prezimenu";
            BtnPretraziPoImenuIPrezimenu.UseVisualStyleBackColor = false;
            // 
            // btnPretraziPoMestu
            // 
            BtnPretraziPoMestu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretraziPoMestu.FlatAppearance.BorderSize = 0;
            BtnPretraziPoMestu.FlatStyle = FlatStyle.Flat;
            BtnPretraziPoMestu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretraziPoMestu.ForeColor = Color.White;
            BtnPretraziPoMestu.Location = new Point(334, 115);
            BtnPretraziPoMestu.Name = "btnPretraziPoMestu";
            BtnPretraziPoMestu.Size = new Size(262, 39);
            BtnPretraziPoMestu.TabIndex = 5;
            BtnPretraziPoMestu.Text = "Pretraži po mestu";
            BtnPretraziPoMestu.UseVisualStyleBackColor = false;
            // 
            // dgvKupci
            // 
            DgvKupci.ReadOnly = true;
            DgvKupci.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvKupci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvKupci.DefaultCellStyle = dataGridViewCellStyle2;
            DgvKupci.EnableHeadersVisualStyles = false;
            DgvKupci.GridColor = Color.FromArgb(230, 230, 230);
            DgvKupci.Location = new Point(67, 188);
            DgvKupci.Name = "dgvKupci";
            DgvKupci.RowHeadersVisible = false;
            DgvKupci.RowHeadersWidth = 51;
            DgvKupci.Size = new Size(528, 177);
            DgvKupci.TabIndex = 6;
            // 
            // btnPrikazOdabranog
            // 
            BtnPrikazOdabranog.BackColor = Color.FromArgb(0, 120, 215);
            BtnPrikazOdabranog.FlatAppearance.BorderSize = 0;
            BtnPrikazOdabranog.FlatStyle = FlatStyle.Flat;
            BtnPrikazOdabranog.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrikazOdabranog.ForeColor = Color.White;
            BtnPrikazOdabranog.Location = new Point(100, 371);
            BtnPrikazOdabranog.Name = "btnPrikazOdabranog";
            BtnPrikazOdabranog.Size = new Size(226, 39);
            BtnPrikazOdabranog.TabIndex = 7;
            BtnPrikazOdabranog.Text = "Promeni kupca";
            BtnPrikazOdabranog.UseVisualStyleBackColor = false;
            // 
            // cmbMesto
            // 
            CmbMesto.FlatStyle = FlatStyle.Flat;
            CmbMesto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbMesto.FormattingEnabled = true;
            CmbMesto.Location = new Point(57, 121);
            CmbMesto.Name = "cmbMesto";
            CmbMesto.Size = new Size(265, 31);
            CmbMesto.TabIndex = 8;
            // 
            // ucPretraziKupca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CmbMesto);
            Controls.Add(BtnPrikazOdabranog);
            Controls.Add(DgvKupci);
            Controls.Add(BtnPretraziPoMestu);
            Controls.Add(BtnPretraziPoImenuIPrezimenu);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TxtImePrezime);
            Controls.Add(BtnObrisi);
            Name = "ucPretraziKupca";
            Size = new Size(659, 450);
            ((System.ComponentModel.ISupportInitialize)DgvKupci).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtImePrezime;
        private Label label1;
        private Label label2;
        private Button btnPretraziPoImenuIPrezimenu;
        private Button btnPretraziPoMestu;
        private DataGridView dgvKupci;
        private Button btnPrikazOdabranog;
        private ComboBox cmbMesto;
        private Button btnObrisi;

        public TextBox TxtImePrezime { get => txtImePrezime; set => txtImePrezime = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnPretraziPoImenuIPrezimenu { get => btnPretraziPoImenuIPrezimenu; set => btnPretraziPoImenuIPrezimenu = value; }
        public Button BtnPretraziPoMestu { get => btnPretraziPoMestu; set => btnPretraziPoMestu = value; }
        public DataGridView DgvKupci { get => dgvKupci; set => dgvKupci = value; }
        public Button BtnPrikazOdabranog { get => btnPrikazOdabranog; set => btnPrikazOdabranog = value; }
        public ComboBox CmbMesto { get => cmbMesto; set => cmbMesto = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
    }
}
