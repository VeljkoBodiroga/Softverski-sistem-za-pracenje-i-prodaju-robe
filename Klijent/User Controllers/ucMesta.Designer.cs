namespace Klijent.User_Controllers
{
    partial class ucMesta
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
            DgvMesta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvMesta).BeginInit();
            SuspendLayout();
            // 
            // dgvMesta
            // 
            DgvMesta.ReadOnly = true;
            DgvMesta.BackgroundColor = Color.White;
            DgvMesta.BorderStyle = BorderStyle.FixedSingle;
            DgvMesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMesta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            DgvMesta.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DgvMesta.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DgvMesta.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DgvMesta.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            DgvMesta.DefaultCellStyle.SelectionForeColor = Color.Black;
            DgvMesta.EnableHeadersVisualStyles = false;
            DgvMesta.GridColor = Color.FromArgb(230, 230, 230);
            DgvMesta.RowHeadersVisible = false;
            DgvMesta.Location = new Point(42, 73);
            DgvMesta.Name = "dgvMesta";
            DgvMesta.RowHeadersWidth = 51;
            DgvMesta.Size = new Size(362, 157);
            DgvMesta.TabIndex = 0;
            // 
            // ucMesta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvMesta);
            Name = "ucMesta";
            Size = new Size(445, 297);
            ((System.ComponentModel.ISupportInitialize)DgvMesta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMesta;

        public DataGridView DgvMesta { get => dgvMesta; set => dgvMesta = value; }
    }
}
