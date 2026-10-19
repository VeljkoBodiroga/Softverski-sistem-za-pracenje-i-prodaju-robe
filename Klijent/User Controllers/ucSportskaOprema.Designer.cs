namespace Klijent.User_Controllers
{
    partial class ucSportskaOprema
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
            DgvSportskaOprema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvSportskaOprema).BeginInit();
            SuspendLayout();
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
            DgvSportskaOprema.Location = new Point(56, 77);
            DgvSportskaOprema.Name = "dgvSportskaOprema";
            DgvSportskaOprema.RowHeadersWidth = 51;
            DgvSportskaOprema.Size = new Size(435, 213);
            DgvSportskaOprema.TabIndex = 0;
            // 
            // ucSportskaOprema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvSportskaOprema);
            Name = "ucSportskaOprema";
            Size = new Size(546, 371);
            ((System.ComponentModel.ISupportInitialize)DgvSportskaOprema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSportskaOprema;

        public DataGridView DgvSportskaOprema { get => dgvSportskaOprema; set => dgvSportskaOprema = value; }
    }
}
