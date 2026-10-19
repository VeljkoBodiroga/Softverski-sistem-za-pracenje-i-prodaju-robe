using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class PronadjiMestoPoIdSO : BaseSO
    {
        private readonly Mesto m;
        public Mesto Result { get; set; }

        public PronadjiMestoPoIdSO(Mesto m)
        {
            this.m = m;
        }

        protected override void ExecuteConcreteOperation()
        {
            string condition = $"idMesto = '{m.IdMesto}'";
            m.SelectCondition = condition;
            List<IEntity> lista = broker.GetByCondition(m);
            Result = lista.Cast<Mesto>().FirstOrDefault();

            if (Result == null)
            {
                throw new Exception("Ne postoji korisnik sa ovim kredencijalima.");
            }
        }
    }
}
