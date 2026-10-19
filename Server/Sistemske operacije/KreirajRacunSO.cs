using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class KreirajRacunSO : BaseSO
    {
        private Racun racun;
        public int Result { get; private set; }

        public KreirajRacunSO(Racun racun)
        {
            this.racun = racun;
        }
        protected override void ExecuteConcreteOperation()
        {
            int indeks = broker.Create(racun);
            Result = indeks;
            // update
            racun.IdRacun = indeks;
            racun.SelectCondition = $"idRacun = {racun.IdRacun}";
            
            foreach (var item in racun.listaStavki)
            {
                item.IdRacun = racun.IdRacun;
                item.Values = $"{item.IdRacun}, '{item.Naziv}', {item.Kolicina}, {item.CenaStavke.ToString(CultureInfo.InvariantCulture)}, {item.idSportskeOpreme}";
                
                broker.Add(item);
            }
        }
    }
}
