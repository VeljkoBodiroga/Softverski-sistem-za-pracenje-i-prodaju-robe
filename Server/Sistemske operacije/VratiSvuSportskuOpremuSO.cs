using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiSvuSportskuOpremuSO : BaseSO
    {
        public List<SportskaOprema> Result { get; internal set; }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> lista = broker.GetAll(new SportskaOprema());
            Result = lista.Cast<SportskaOprema>().ToList();
        }
    }
}
