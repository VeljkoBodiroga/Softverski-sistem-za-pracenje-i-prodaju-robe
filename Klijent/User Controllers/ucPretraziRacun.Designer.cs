namespace Klijent.User_Controllers
{
    partial class ucPretraziRacun
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
            DataGridView1 = new DataGridView();
            BtnPrikazProdavaca = new Button();
            BtnPrikazKupaca = new Button();
            TxtIznos = new TextBox();
            BtnPretragaPoKupcu = new Button();
            BtnPretragaPoProdavcu = new Button();
            CmbZnak = new ComboBox();
            BtnPretraziPoIznosu = new Button();
            DtpDatum = new DateTimePicker();
            BtnPretraziPoDatumu = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            DataGridView1.ReadOnly = true;  
            DataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView1.EnableHeadersVisualStyles = false;
            DataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            DataGridView1.Location = new Point(325, 132);
            DataGridView1.Name = "dataGridView1";
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(360, 215);
            DataGridView1.TabIndex = 0;
            // 
            // btnPrikazProdavaca
            // 
            BtnPrikazProdavaca.BackColor = Color.FromArgb(0, 120, 215);
            BtnPrikazProdavaca.FlatAppearance.BorderSize = 0;
            BtnPrikazProdavaca.FlatStyle = FlatStyle.Flat;
            BtnPrikazProdavaca.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrikazProdavaca.ForeColor = Color.White;
            BtnPrikazProdavaca.Location = new Point(325, 90);
            BtnPrikazProdavaca.Name = "btnPrikazProdavaca";
            BtnPrikazProdavaca.Size = new Size(172, 34);
            BtnPrikazProdavaca.TabIndex = 1;
            BtnPrikazProdavaca.Text = "Prikaži prodavce";
            BtnPrikazProdavaca.UseVisualStyleBackColor = false;
            // 
            // btnPrikazKupaca
            // 
            BtnPrikazKupaca.BackColor = Color.FromArgb(0, 120, 215);
            BtnPrikazKupaca.FlatAppearance.BorderSize = 0;
            BtnPrikazKupaca.FlatStyle = FlatStyle.Flat;
            BtnPrikazKupaca.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrikazKupaca.ForeColor = Color.White;
            BtnPrikazKupaca.Location = new Point(514, 90);
            BtnPrikazKupaca.Name = "btnPrikazKupaca";
            BtnPrikazKupaca.Size = new Size(171, 34);
            BtnPrikazKupaca.TabIndex = 2;
            BtnPrikazKupaca.Text = "Prikaži kupce";
            BtnPrikazKupaca.UseVisualStyleBackColor = false;
            // 
            // txtIznos
            // 
            TxtIznos.BorderStyle = BorderStyle.FixedSingle;
            TxtIznos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIznos.Location = new Point(120, 158);
            TxtIznos.Name = "txtIznos";
            TxtIznos.Size = new Size(135, 30);
            TxtIznos.TabIndex = 3;
            // 
            // btnPretragaPoKupcu
            // 
            BtnPretragaPoKupcu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretragaPoKupcu.FlatAppearance.BorderSize = 0;
            BtnPretragaPoKupcu.FlatStyle = FlatStyle.Flat;
            BtnPretragaPoKupcu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretragaPoKupcu.ForeColor = Color.White;
            BtnPretragaPoKupcu.Location = new Point(514, 355);
            BtnPretragaPoKupcu.Name = "btnPretragaPoKupcu";
            BtnPretragaPoKupcu.Size = new Size(171, 34);
            BtnPretragaPoKupcu.TabIndex = 5;
            BtnPretragaPoKupcu.Text = "Pretraga po kupcu";
            BtnPretragaPoKupcu.UseVisualStyleBackColor = false;
            // 
            // btnPretragaPoProdavcu
            // 
            BtnPretragaPoProdavcu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretragaPoProdavcu.FlatAppearance.BorderSize = 0;
            BtnPretragaPoProdavcu.FlatStyle = FlatStyle.Flat;
            BtnPretragaPoProdavcu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretragaPoProdavcu.ForeColor = Color.White;
            BtnPretragaPoProdavcu.Location = new Point(325, 355);
            BtnPretragaPoProdavcu.Name = "btnPretragaPoProdavcu";
            BtnPretragaPoProdavcu.Size = new Size(172, 34);
            BtnPretragaPoProdavcu.TabIndex = 4;
            BtnPretragaPoProdavcu.Text = "Pretraga po prodavcu";
            BtnPretragaPoProdavcu.UseVisualStyleBackColor = false;
            // 
            // cmbZnak
            // 
            CmbZnak.AutoCompleteCustomSource.AddRange(new string[] { ">", "<", "=", ">=", "<=" });
            CmbZnak.FlatStyle = FlatStyle.Flat;
            CmbZnak.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbZnak.FormattingEnabled = true;
            CmbZnak.Location = new Point(70, 158);
            CmbZnak.Name = "cmbZnak";
            CmbZnak.Size = new Size(44, 31);
            CmbZnak.TabIndex = 6;
            // 
            // btnPretraziPoIznosu
            // 
            BtnPretraziPoIznosu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretraziPoIznosu.FlatAppearance.BorderSize = 0;
            BtnPretraziPoIznosu.FlatStyle = FlatStyle.Flat;
            BtnPretraziPoIznosu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretraziPoIznosu.ForeColor = Color.White;
            BtnPretraziPoIznosu.Location = new Point(70, 197);
            BtnPretraziPoIznosu.Name = "btnPretraziPoIznosu";
            BtnPretraziPoIznosu.Size = new Size(185, 34);
            BtnPretraziPoIznosu.TabIndex = 7;
            BtnPretraziPoIznosu.Text = "Pretraži po iznosu";
            BtnPretraziPoIznosu.UseVisualStyleBackColor = false;
            // 
            // dtpDatum
            // 
            DtpDatum.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpDatum.Location = new Point(40, 266);
            DtpDatum.Name = "dtpDatum";
            DtpDatum.Size = new Size(245, 30);
            DtpDatum.TabIndex = 8;
            // 
            // btnPretraziPoDatumu
            // 
            BtnPretraziPoDatumu.BackColor = Color.FromArgb(0, 120, 215);
            BtnPretraziPoDatumu.FlatAppearance.BorderSize = 0;
            BtnPretraziPoDatumu.FlatStyle = FlatStyle.Flat;
            BtnPretraziPoDatumu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPretraziPoDatumu.ForeColor = Color.White;
            BtnPretraziPoDatumu.Location = new Point(40, 305);
            BtnPretraziPoDatumu.Name = "btnPretraziPoDatumu";
            BtnPretraziPoDatumu.Size = new Size(245, 34);
            BtnPretraziPoDatumu.TabIndex = 9;
            BtnPretraziPoDatumu.Text = "Pretraži po datumu";
            BtnPretraziPoDatumu.UseVisualStyleBackColor = false;
            // 
            // ucPretraziRacun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnPretraziPoDatumu);
            Controls.Add(DtpDatum);
            Controls.Add(BtnPretraziPoIznosu);
            Controls.Add(CmbZnak);
            Controls.Add(BtnPretragaPoKupcu);
            Controls.Add(BtnPretragaPoProdavcu);
            Controls.Add(TxtIznos);
            Controls.Add(BtnPrikazKupaca);
            Controls.Add(BtnPrikazProdavaca);
            Controls.Add(DataGridView1);
            Name = "ucPretraziRacun";
            Size = new Size(756, 484);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPrikazProdavaca;
        private Button btnPrikazKupaca;
        private TextBox txtIznos;
        private Button btnPretragaPoKupcu;
        private Button btnPretragaPoProdavcu;
        private ComboBox cmbZnak;
        private Button btnPretraziPoIznosu;
        private DateTimePicker dtpDatum;
        private Button btnPretraziPoDatumu;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Button BtnPrikazProdavaca { get => btnPrikazProdavaca; set => btnPrikazProdavaca = value; }
        public Button BtnPrikazKupaca { get => btnPrikazKupaca; set => btnPrikazKupaca = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Button BtnPretragaPoKupcu { get => btnPretragaPoKupcu; set => btnPretragaPoKupcu = value; }
        public Button BtnPretragaPoProdavcu { get => btnPretragaPoProdavcu; set => btnPretragaPoProdavcu = value; }
        public ComboBox CmbZnak { get => cmbZnak; set => cmbZnak = value; }
        public Button BtnPretraziPoIznosu { get => btnPretraziPoIznosu; set => btnPretraziPoIznosu = value; }
        public DateTimePicker DtpDatum { get => dtpDatum; set => dtpDatum = value; }
        public Button BtnPretraziPoDatumu { get => btnPretraziPoDatumu; set => btnPretraziPoDatumu = value; }
    }
}
