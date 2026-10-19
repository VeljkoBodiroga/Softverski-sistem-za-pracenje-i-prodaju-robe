using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiRacunePoIznosuSO : BaseSO
    {
        private Racun racun;

        public VratiRacunePoIznosuSO(Racun racun)
        {
            this.racun = racun;
        }

        public object Result { get; internal set; }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> list = broker.GetByCondition(racun);
            Result = list.Cast<Racun>().ToList();
        }
    }
}
