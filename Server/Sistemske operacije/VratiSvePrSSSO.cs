using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiSvePrSSSO : BaseSO
    {
        private PrSS prSS;

        public VratiSvePrSSSO(PrSS prSS)
        {
            this.prSS = prSS;
        }
        public List<PrSS> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> list = broker.GetByCondition(prSS);
            Result = list.Cast<PrSS>().ToList();
        }
    }
}
