using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Klijent.User_Controllers;
using System.ComponentModel;

namespace Klijent.Controllers
{
    internal class PrikaziMestaController
    {
        ucMesta ucMesta;
        List<Mesto> mesta;
        internal Control CreatePrikaziMesta()
        {
            ucMesta= new ucMesta();

            ucMesta.DgvMesta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ucMesta.Load += UcitajMesta;

            return ucMesta;
        }

        private void UcitajMesta(object? sender, EventArgs e)
        {
            mesta = Komunikacija.instance.VratiSvaMesta();
            ucMesta.DgvMesta.DataSource = mesta;

            foreach (DataGridViewColumn col in ucMesta.DgvMesta.Columns)
            {
                col.Visible = false;
            }

            ucMesta.DgvMesta.Columns[1].Visible = true;
            ucMesta.DgvMesta.Columns[2].Visible = true;
        }
    }
}
