using Klijent.User_Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent.Controllers
{
    internal class PrikaziListuRacunaController
    {
        ucPrikaziListuRacuna ucPrikaziListuRacuna;
        List<Racun> listaIzabranihRacuna=new List<Racun>();
        internal Control CreatePrikaziRacune(List<Racun> listaRacuna)
        {
            ucPrikaziListuRacuna = new ucPrikaziListuRacuna();

            listaIzabranihRacuna = listaRacuna;
            ucPrikaziListuRacuna.BtnVratise.Click += VratiSeNaPretragu;
            ucPrikaziListuRacuna.BtnPromeniRacun.Click += PromeniRacun;

            ucPrikaziListuRacuna.DgvListaRacuna.DataSource = listaIzabranihRacuna;
            foreach (DataGridViewColumn col in ucPrikaziListuRacuna.DgvListaRacuna.Columns)
            {
                col.Visible = false;
            }
            ucPrikaziListuRacuna.DgvListaRacuna.Columns[1].Visible = true;
            ucPrikaziListuRacuna.DgvListaRacuna.Columns[2].Visible = true;
            ucPrikaziListuRacuna.DgvListaRacuna.Columns[3].Visible = true;

            ucPrikaziListuRacuna.DgvListaRacuna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return ucPrikaziListuRacuna;
        }

        private void PromeniRacun(object? sender, EventArgs e)
        {
            if(ucPrikaziListuRacuna.DgvListaRacuna.CurrentRow == null)
            {
                MessageBox.Show("Izaberite racun koji hocete da promenite");

            }
            else
            {
                StavkaRacuna sr = new StavkaRacuna();
                MainCoordinator.Instance.ShowPromeniRacun((Racun)ucPrikaziListuRacuna.DgvListaRacuna.CurrentRow.DataBoundItem,sr);

            }
        }

        private void VratiSeNaPretragu(object? sender, EventArgs e)
        {
            MainCoordinator.Instance.ShowPretraziRacun();
        }
    }
}
