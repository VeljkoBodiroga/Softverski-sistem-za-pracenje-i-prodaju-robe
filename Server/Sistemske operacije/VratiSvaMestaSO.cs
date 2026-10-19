using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiSvaMestaSO : BaseSO
    {
        public List<Mesto> Result {  get; set; }
        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> lista = broker.GetAll(new Mesto());
            Result = lista.Cast<Mesto>().ToList();
        }
    }
}
