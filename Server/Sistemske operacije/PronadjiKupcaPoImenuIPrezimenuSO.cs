using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class PronadjiKupcaPoImenuIPrezimenuSO : BaseSO
    {
        private readonly Kupac k;
        public Kupac Result { get; set; }

        public PronadjiKupcaPoImenuIPrezimenuSO(Kupac k)
        {
            this.k = k;
        }
        protected override void ExecuteConcreteOperation()
        {
            string condition = $"ime = '{k.Ime}' and prezime = '{k.Prezime}'";
            k.SelectCondition = condition;
            List<IEntity> lista = broker.GetByCondition(k);
            Result = lista.Cast<Kupac>().FirstOrDefault();

            
        }
    }
}
