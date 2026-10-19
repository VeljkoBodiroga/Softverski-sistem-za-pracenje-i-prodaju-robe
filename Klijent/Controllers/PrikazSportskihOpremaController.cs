using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Klijent.User_Controllers;

namespace Klijent.Controllers
{
    
    internal class PrikazSportskihOpremaController
    {
        ucSportskaOprema ucSportskaOprema;
        List<SportskaOprema> listaSportskihOprema;

        internal Control CreatePrikaziSportskeOpreme()
        {
            ucSportskaOprema = new ucSportskaOprema();

            ucSportskaOprema.DgvSportskaOprema.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucSportskaOprema.Load += UcitajSportskeOpreme;

            return ucSportskaOprema;
        }

        private void UcitajSportskeOpreme(object? sender, EventArgs e)
        {
            listaSportskihOprema = Komunikacija.instance.VratiSvuSportskuOpremu();
            ucSportskaOprema.DgvSportskaOprema.DataSource = listaSportskihOprema;

            foreach (DataGridViewColumn col in ucSportskaOprema.DgvSportskaOprema.Columns)
            {
                col.Visible = false;
            }

            ucSportskaOprema.DgvSportskaOprema.Columns[1].Visible = true;
            ucSportskaOprema.DgvSportskaOprema.Columns[2].Visible = true;
            ucSportskaOprema.DgvSportskaOprema.Columns[4].Visible = true;

        }
    }
}
