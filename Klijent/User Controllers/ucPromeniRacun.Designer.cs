using System.Windows.Forms;

namespace Klijent.User_Controllers
{
    partial class ucPromeniRacun
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
            DgvProdavci = new DataGridView();
            DgvKupci = new DataGridView();
            DgvStavke = new DataGridView();
            Label1 = new Label();
            Label2 = new Label();
            DtpDatum = new DateTimePicker();
            TxtAdresa = new TextBox();
            Label3 = new Label();
            TxtIznos = new TextBox();
            BtnPromeniRacun = new Button();
            BtnDodajStavku = new Button();
            Label4 = new Label();
            Label5 = new Label();
            BtnObrisiStavku = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProdavci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvKupci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvStavke).BeginInit();
            SuspendLayout();
            // 
            // DgvProdavci
            // 
            DgvProdavci.ReadOnly = true;
            DgvProdavci.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvProdavci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvProdavci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvProdavci.DefaultCellStyle = dataGridViewCellStyle2;
            DgvProdavci.EnableHeadersVisualStyles = false;
            DgvProdavci.GridColor = Color.FromArgb(230, 230, 230);
            DgvProdavci.Location = new Point(38, 54);
            DgvProdavci.Name = "DgvProdavci";
            DgvProdavci.RowHeadersVisible = false;
            DgvProdavci.RowHeadersWidth = 51;
            DgvProdavci.Size = new Size(294, 114);
            DgvProdavci.TabIndex = 0;
            // 
            // DgvKupci
            // 
            DgvKupci.ReadOnly = true;
            DgvKupci.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvKupci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvKupci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvKupci.DefaultCellStyle = dataGridViewCellStyle4;
            DgvKupci.EnableHeadersVisualStyles = false;
            DgvKupci.GridColor = Color.FromArgb(230, 230, 230);
            DgvKupci.Location = new Point(38, 220);
            DgvKupci.Name = "DgvKupci";
            DgvKupci.RowHeadersVisible = false;
            DgvKupci.RowHeadersWidth = 51;
            DgvKupci.Size = new Size(294, 114);
            DgvKupci.TabIndex = 1;
            // 
            // DgvStavke
            // 
            DgvStavke.ReadOnly = true;
            DgvStavke.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DgvStavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DgvStavke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DgvStavke.DefaultCellStyle = dataGridViewCellStyle6;
            DgvStavke.EnableHeadersVisualStyles = false;
            DgvStavke.GridColor = Color.FromArgb(230, 230, 230);
            DgvStavke.Location = new Point(376, 92);
            DgvStavke.Name = "DgvStavke";
            DgvStavke.RowHeadersVisible = false;
            DgvStavke.RowHeadersWidth = 51;
            DgvStavke.Size = new Size(380, 200);
            DgvStavke.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(64, 64, 64);
            Label1.Location = new Point(376, 311);
            Label1.Name = "Label1";
            Label1.Size = new Size(138, 23);
            Label1.TabIndex = 3;
            Label1.Text = "Adresa izdavanja";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(64, 64, 64);
            Label2.Location = new Point(376, 406);
            Label2.Name = "Label2";
            Label2.Size = new Size(138, 23);
            Label2.TabIndex = 4;
            Label2.Text = "Iznos";
            // 
            // DtpDatum
            // 
            DtpDatum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpDatum.Location = new Point(510, 354);
            DtpDatum.Name = "DtpDatum";
            DtpDatum.Size = new Size(245, 30);
            DtpDatum.TabIndex = 5;
            // 
            // TxtAdresa
            // 
            TxtAdresa.BorderStyle = BorderStyle.FixedSingle;
            TxtAdresa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAdresa.Location = new Point(510, 309);
            TxtAdresa.Name = "TxtAdresa";
            TxtAdresa.Size = new Size(245, 30);
            TxtAdresa.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(64, 64, 64);
            Label3.Location = new Point(376, 356);
            Label3.Name = "Label3";
            Label3.Size = new Size(50, 23);
            Label3.TabIndex = 7;
            Label3.Text = "Datum izdavanja";
            // 
            // TxtIznos
            // 
            TxtIznos.BorderStyle = BorderStyle.FixedSingle;
            TxtIznos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIznos.Location = new Point(510, 400);
            TxtIznos.Name = "TxtIznos";
            TxtIznos.Size = new Size(80, 30);
            TxtIznos.TabIndex = 8;
            // 
            // BtnPromeniRacun
            // 
            BtnPromeniRacun.BackColor = Color.FromArgb(0, 120, 215);
            BtnPromeniRacun.FlatAppearance.BorderSize = 0;
            BtnPromeniRacun.FlatStyle = FlatStyle.Flat;
            BtnPromeniRacun.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPromeniRacun.ForeColor = Color.White;
            BtnPromeniRacun.Location = new Point(53, 356);
            BtnPromeniRacun.Name = "BtnPromeniRacun";
            BtnPromeniRacun.Size = new Size(261, 67);
            BtnPromeniRacun.TabIndex = 9;
            BtnPromeniRacun.Text = "Promeni račun";
            BtnPromeniRacun.UseVisualStyleBackColor = false;
            // 
            // BtnDodajStavku
            // 
            BtnDodajStavku.BackColor = Color.FromArgb(0, 120, 215);
            BtnDodajStavku.FlatAppearance.BorderSize = 0;
            BtnDodajStavku.FlatStyle = FlatStyle.Flat;
            BtnDodajStavku.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDodajStavku.ForeColor = Color.White;
            BtnDodajStavku.Location = new Point(583, 53);
            BtnDodajStavku.Name = "BtnDodajStavku";
            BtnDodajStavku.Size = new Size(163, 33);
            BtnDodajStavku.TabIndex = 10;
            BtnDodajStavku.Text = "Dodaj novu stavku";
            BtnDodajStavku.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.FromArgb(64, 64, 64);
            Label4.Location = new Point(38, 27);
            Label4.Name = "Label4";
            Label4.Size = new Size(75, 23);
            Label4.TabIndex = 11;
            Label4.Text = "Prodavci";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.FromArgb(64, 64, 64);
            Label5.Location = new Point(38, 193);
            Label5.Name = "Label5";
            Label5.Size = new Size(52, 23);
            Label5.TabIndex = 12;
            Label5.Text = "Kupci";
            // 
            // BtnObrisiStavku
            // 
            BtnObrisiStavku.BackColor = Color.FromArgb(196, 43, 28);
            BtnObrisiStavku.FlatAppearance.BorderSize = 0;
            BtnObrisiStavku.FlatStyle = FlatStyle.Flat;
            BtnObrisiStavku.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnObrisiStavku.ForeColor = Color.White;
            BtnObrisiStavku.Location = new Point(386, 53);
            BtnObrisiStavku.Name = "BtnObrisiStavku";
            BtnObrisiStavku.Size = new Size(163, 33);
            BtnObrisiStavku.TabIndex = 13;
            BtnObrisiStavku.Text = "Obriši stavku";
            BtnObrisiStavku.UseVisualStyleBackColor = false;
            // 
            // ucPromeniRacun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnObrisiStavku);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(BtnDodajStavku);
            Controls.Add(BtnPromeniRacun);
            Controls.Add(TxtIznos);
            Controls.Add(Label3);
            Controls.Add(TxtAdresa);
            Controls.Add(DtpDatum);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(DgvStavke);
            Controls.Add(DgvKupci);
            Controls.Add(DgvProdavci);
            Name = "ucPromeniRacun";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)DgvProdavci).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvKupci).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvStavke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdavci;
        private DataGridView dgvKupci;
        private DataGridView dgvStavke;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDatum;
        private TextBox txtAdresa;
        private Label label3;
        private TextBox txtIznos;
        private Button btnPromeniRacun;
        private Button btnDodajStavku;
        private Label label4;
        private Label label5;
        private Button btnObrisiStavku;

        public DataGridView DgvProdavci { get => dgvProdavci; set => dgvProdavci = value; }
        public DataGridView DgvKupci { get => dgvKupci; set => dgvKupci = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Button BtnPromeniRacun { get => btnPromeniRacun; set => btnPromeniRacun = value; }
        public Button BtnDodajStavku { get => btnDodajStavku; set => btnDodajStavku = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnObrisiStavku { get => btnObrisiStavku; set => btnObrisiStavku = value; }
    }
}
