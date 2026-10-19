using Klijent.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void ChangePanel(Control control)
        {
            panel1.Controls.Clear();

            panel1.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            this.CenterToScreen();


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowLogInControl();
        }
    }
}
