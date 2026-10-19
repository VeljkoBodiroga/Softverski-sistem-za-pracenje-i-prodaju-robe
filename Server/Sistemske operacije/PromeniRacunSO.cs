using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class PromeniRacunSO : BaseSO
    {
        private Racun r;

        public PromeniRacunSO(Racun r)
        {
            this.r = r;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.UpdateByCondition(r);
            Debug.WriteLine($">>>>> UKUPNO STAVKI U r.listaStavki: {r.listaStavki.Count}");

            foreach (StavkaRacuna stavka in r.listaStavki)
            {
                string condition = $"idRacun = {r.IdRacun}";

                Debug.WriteLine($">>>>> STAVKA: {stavka.Naziv} | zaBrisanje={stavka.zaBrisanje} | zaDodavanje={stavka.zaDodavanje} | Values='{stavka.Values}'");

                if (stavka.zaBrisanje)
                {
                    stavka.SelectCondition = condition;
                    Debug.WriteLine($">>>>> BRISEM stavku {stavka.IdStavkaRacuna} sa condition: {stavka.SelectCondition}");
                    broker.DeleteEntity(stavka);
                }
                else if (stavka.zaDodavanje)
                {
                    Debug.WriteLine($">>>>> DODAJEM stavku, Values: {stavka.Values}");
                    broker.Add(stavka);
                }
            }
        }
    }
}
