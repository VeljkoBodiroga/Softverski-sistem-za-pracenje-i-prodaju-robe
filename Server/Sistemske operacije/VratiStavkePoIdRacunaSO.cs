using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class VratiStavkePoIdRacunaSO:BaseSO
    {
        private Racun racun;

        public VratiStavkePoIdRacunaSO(Racun racun)
        {
            this.racun = racun;
        }

        public object Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            StavkaRacuna pom = new StavkaRacuna
            {
                SelectCondition = racun.SelectCondition
            };
            List<IEntity> list = broker.GetByCondition(pom);
            Result = list.Cast<StavkaRacuna>().ToList();
        }
    }
}
