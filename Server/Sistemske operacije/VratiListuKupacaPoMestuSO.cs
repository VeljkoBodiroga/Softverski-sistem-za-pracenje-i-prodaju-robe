using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiListuKupacaPoMestuSO : BaseSO
    {
        private readonly Kupac k;
        public List<Kupac> Result { get; set; }

        public VratiListuKupacaPoMestuSO(Kupac k)
        {
            this.k =k;
        }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> list = broker.GetByCondition(k);
            Result = list.Cast<Kupac>().ToList();
        }
    }
}
