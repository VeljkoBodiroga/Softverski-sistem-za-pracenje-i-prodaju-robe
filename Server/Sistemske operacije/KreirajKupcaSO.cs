using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class KreirajKupcaSO : BaseSO
    {
        private Kupac k;

        public KreirajKupcaSO(Kupac k)
        {
            this.k = k;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(k);  
        }
    }
}
