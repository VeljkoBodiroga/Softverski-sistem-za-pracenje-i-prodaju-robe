using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiSveProdavceSO : BaseSO
    {
        public List<Prodavac> Result { get; internal set; }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> lista = broker.GetAll(new Prodavac());
            Result = lista.Cast<Prodavac>().ToList();
        }
    }
}
