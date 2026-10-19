using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    public class PrijaviProdavcaSO : BaseSO
    {
        private readonly Prodavac p;

        public Prodavac Result { get; set; }

        public PrijaviProdavcaSO(Prodavac p)
        {
            this.p = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            string condition = $"korisnickoIme = '{p.KorisnikoIme}' and sifra = '{p.Sifra}'";
            p.SelectCondition = condition;
            List<IEntity> lista = broker.GetByCondition(p);
            Result = lista.Cast<Prodavac>().FirstOrDefault();

            //if (Result == null)
            //{
            //    throw new Exception("Ne postoji korisnik sa ovim kredencijalima.");
            //}

        }
    }
}
