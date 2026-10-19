using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class PronadjiStrucnuSpremuSO : BaseSO
    {
        private StrucnaSprema strucnaSprema;

        public PronadjiStrucnuSpremuSO(StrucnaSprema strucnaSprema)
        {
            this.strucnaSprema = strucnaSprema;
        }

        public StrucnaSprema Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            List<IEntity> lista = broker.GetByCondition(strucnaSprema);
            Result = lista.Cast<StrucnaSprema>().FirstOrDefault();
        }
    }
}
