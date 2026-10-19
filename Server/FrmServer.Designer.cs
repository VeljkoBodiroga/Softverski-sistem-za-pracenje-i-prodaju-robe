namespace Server
{
    partial class FrmServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblOpis = new Label();
            btnStop = new Button();
            btnStart = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblOpis);
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnStart);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.server;
            pictureBox1.Location = new Point(68, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpis.ForeColor = Color.FromArgb(64, 64, 64);
            lblOpis.Location = new Point(438, 337);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(284, 41);
            lblOpis.TabIndex = 2;
            lblOpis.Text = "Server nije pokrenut";
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(220, 90, 80);
            btnStop.Enabled = false;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(455, 190);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(250, 100);
            btnStop.TabIndex = 1;
            btnStop.Text = "Zaustavi";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(100, 180, 120);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(455, 49);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(250, 100);
            btnStart.TabIndex = 0;
            btnStart.Text = "Pokreni";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // FrmServer
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmServer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            FormClosed += FrmServer_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnStart;
        private Label lblOpis;
        private Button btnStop;
        private PictureBox pictureBox1;
    }
}
