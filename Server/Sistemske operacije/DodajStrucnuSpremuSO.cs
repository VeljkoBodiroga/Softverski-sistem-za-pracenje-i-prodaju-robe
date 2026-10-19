using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server.Sistemske_operacije
{
    internal class DodajStrucnuSpremuSO:BaseSO
    {
        private StrucnaSprema ss;

        public DodajStrucnuSpremuSO(StrucnaSprema ss)
        {
            this.ss = ss;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(ss);
        }
    }
}
