using Klijent.Controllers;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent
{
    public partial class Glavna : Form
    {
        Prodavac prodavacG = new Prodavac();
        private Control currentControl;

        public Glavna(Prodavac prodavac)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            prodavacG = prodavac;

            prodavacToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPrijavljeniProdavac(prodavacG);
            kreirajKupcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajKupca();
            pretražiKupcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziKupca();
            promeniKupcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziKupca();
            dodajToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowDodajStrucnuSpremu();
            kreirajRačunToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowKreirajRacun();
            pretražiRačunToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziRacun();
            promeniRačunToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziRacun();
            mestoToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowMesta();
            sportskaOpremaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowSportskaOprema();
            obrišiKupcaToolStripMenuItem.Click += (s, e) => MainCoordinator.Instance.ShowPretraziKupca();

            panel.Resize += Panel_Resize;
            this.CenterToScreen();
        }

        private void Panel_Resize(object? sender, EventArgs e)
        {
            if (currentControl != null)
                CenterControl(currentControl);
        }

        public void ChangePanel(Control control)
        {
            panel.Controls.Clear();
            panel.Controls.Add(control);
            control.BringToFront();
            control.Anchor = AnchorStyles.None;

            currentControl = control;
            CenterControl(currentControl);

            this.CenterToScreen();
        }

        private void CenterControl(Control uc)
        {
            Rectangle area = panel.ClientRectangle;
            area.X += panel.Padding.Left;
            area.Y += panel.Padding.Top;
            area.Width -= panel.Padding.Horizontal;
            area.Height -= panel.Padding.Vertical;

            uc.Location = new Point(
                area.X + (area.Width - uc.Width) / 2,
                area.Y + (area.Height - uc.Height) / 2
            );
        }






    }
}
