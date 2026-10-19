namespace Klijent.User_Controllers
{
    partial class ucKreirajRacun
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            TxtAdresa = new TextBox();
            Label1 = new Label();
            DtpDatum = new DateTimePicker();
            Label2 = new Label();
            TxtIznos = new TextBox();
            Label3 = new Label();
            DgvStavke = new DataGridView();
            Label4 = new Label();
            BtnDodajStavku = new Button();
            DgvProdavci = new DataGridView();
            DgvKupci = new DataGridView();
            Label5 = new Label();
            Label6 = new Label();
            BtnKreirajRacun = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvStavke).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvProdavci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvKupci).BeginInit();
            SuspendLayout();
            // 
            // txtAdresa
            // 
            TxtAdresa.BorderStyle = BorderStyle.FixedSingle;
            TxtAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAdresa.Location = new Point(504, 319);
            TxtAdresa.Name = "txtAdresa";
            TxtAdresa.Size = new Size(246, 30);
            TxtAdresa.TabIndex = 0;
            TxtAdresa.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(360, 326);
            Label1.Name = "label1";
            Label1.Size = new Size(138, 23);
            Label1.TabIndex = 2;
            Label1.Text = "Adresa izdavanja";
            // 
            // dtpDatum
            // 
            DtpDatum.CalendarMonthBackground = Color.White;
            DtpDatum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpDatum.Location = new Point(504, 360);
            DtpDatum.Name = "dtpDatum";
            DtpDatum.Size = new Size(246, 30);
            DtpDatum.TabIndex = 3;
            // 
            // label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(360, 366);
            Label2.Name = "label2";
            Label2.Size = new Size(138, 23);
            Label2.TabIndex = 4;
            Label2.Text = "Datum izdavanja";
            // 
            // txtIznos
            // 
            TxtIznos.BorderStyle = BorderStyle.FixedSingle;
            TxtIznos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIznos.Location = new Point(504, 401);
            TxtIznos.Name = "txtIznos";
            TxtIznos.Size = new Size(156, 30);
            TxtIznos.TabIndex = 5;
            TxtIznos.TextChanged += txtIznos_TextChanged;
            // 
            // label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(360, 403);
            Label3.Name = "label3";
            Label3.Size = new Size(113, 23);
            Label3.TabIndex = 6;
            Label3.Text = "Ukupan iznos";
            // 
            // dgvStavke
            // 
            DgvStavke.ReadOnly = true;
            DgvStavke.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvStavke.DefaultCellStyle = dataGridViewCellStyle2;
            DgvStavke.EnableHeadersVisualStyles = false;
            DgvStavke.GridColor = Color.FromArgb(230, 230, 230);
            DgvStavke.Location = new Point(329, 52);
            DgvStavke.Name = "dgvStavke";
            DgvStavke.RowHeadersVisible = false;
            DgvStavke.RowHeadersWidth = 51;
            DgvStavke.Size = new Size(449, 242);
            DgvStavke.TabIndex = 7;
            // 
            // label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(64, 64, 64);
            Label4.Location = new Point(329, 26);
            Label4.Name = "label4";
            Label4.Size = new Size(119, 23);
            Label4.TabIndex = 8;
            Label4.Text = "Stavke računa:";
            // 
            // btnDodajStavku
            // 
            BtnDodajStavku.BackColor = Color.FromArgb(0, 120, 215);
            BtnDodajStavku.FlatAppearance.BorderSize = 0;
            BtnDodajStavku.FlatStyle = FlatStyle.Flat;
            BtnDodajStavku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDodajStavku.ForeColor = Color.White;
            BtnDodajStavku.Location = new Point(668, 14);
            BtnDodajStavku.Name = "btnDodajStavku";
            BtnDodajStavku.Size = new Size(110, 32);
            BtnDodajStavku.TabIndex = 9;
            BtnDodajStavku.Text = "Dodaj stavku";
            BtnDodajStavku.UseVisualStyleBackColor = false;
            // 
            // dgvProdavci
            // 
            DgvProdavci.ReadOnly = true;
            DgvProdavci.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvProdavci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvProdavci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvProdavci.DefaultCellStyle = dataGridViewCellStyle4;
            DgvProdavci.EnableHeadersVisualStyles = false;
            DgvProdavci.GridColor = Color.FromArgb(230, 230, 230);
            DgvProdavci.Location = new Point(24, 52);
            DgvProdavci.Name = "dgvProdavci";
            DgvProdavci.RowHeadersVisible = false;
            DgvProdavci.RowHeadersWidth = 48;
            DgvProdavci.Size = new Size(280, 125);
            DgvProdavci.TabIndex = 10;
            // 
            // dgvKupci
            // 
            DgvKupci.ReadOnly = true;
            DgvKupci.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvKupci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvKupci.DefaultCellStyle = dataGridViewCellStyle6;
            DgvKupci.EnableHeadersVisualStyles = false;
            DgvKupci.GridColor = Color.FromArgb(230, 230, 230);
            DgvKupci.Location = new Point(24, 224);
            DgvKupci.Name = "dgvKupci";
            DgvKupci.RowHeadersVisible = false;
            DgvKupci.RowHeadersWidth = 48;
            DgvKupci.Size = new Size(280, 125);
            DgvKupci.TabIndex = 11;
            // 
            // label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.FromArgb(64, 64, 64);
            Label5.Location = new Point(24, 198);
            Label5.Name = "label5";
            Label5.Size = new Size(107, 23);
            Label5.TabIndex = 12;
            Label5.Text = "Lista kupaca:";
            // 
            // label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.FromArgb(64, 64, 64);
            Label6.Location = new Point(24, 26);
            Label6.Name = "label6";
            Label6.Size = new Size(132, 23);
            Label6.TabIndex = 13;
            Label6.Text = "Lista prodavaca:";
            // 
            // btnKreirajRacun
            // 
            BtnKreirajRacun.BackColor = Color.FromArgb(0, 120, 215);
            BtnKreirajRacun.FlatAppearance.BorderSize = 0;
            BtnKreirajRacun.FlatStyle = FlatStyle.Flat;
            BtnKreirajRacun.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnKreirajRacun.ForeColor = Color.White;
            BtnKreirajRacun.Location = new Point(24, 366);
            BtnKreirajRacun.Name = "btnKreirajRacun";
            BtnKreirajRacun.Size = new Size(280, 60);
            BtnKreirajRacun.TabIndex = 14;
            BtnKreirajRacun.Text = "Kreiraj račun";
            BtnKreirajRacun.UseVisualStyleBackColor = false;
            // 
            // ucKreirajRacun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnKreirajRacun);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(DgvKupci);
            Controls.Add(DgvProdavci);
            Controls.Add(BtnDodajStavku);
            Controls.Add(Label4);
            Controls.Add(DgvStavke);
            Controls.Add(Label3);
            Controls.Add(TxtIznos);
            Controls.Add(Label2);
            Controls.Add(DtpDatum);
            Controls.Add(Label1);
            Controls.Add(TxtAdresa);
            Name = "ucKreirajRacun";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)DgvStavke).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvProdavci).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvKupci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdresa;
        private Label label1;
        private DateTimePicker dtpDatum;
        private Label label2;
        private TextBox txtIznos;
        private Label label3;
        private DataGridView dgvStavke;
        private Label label4;
        private Button btnDodajStavku;
        private DataGridView dgvProdavci;
        private DataGridView dgvKupci;
        private Label label5;
        private Label label6;
        private Button btnKreirajRacun;

        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public DataGridView DgvProdavci { get => dgvProdavci; set => dgvProdavci = value; }
        public DataGridView DgvKupci { get => dgvKupci; set => dgvKupci = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnKreirajRacun { get => btnKreirajRacun; set => btnKreirajRacun = value; }
    }
}
