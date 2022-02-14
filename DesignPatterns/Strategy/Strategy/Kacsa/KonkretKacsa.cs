using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Kacsa
{
    internal class KonkretKacsa : AbstractKacsa
    {
        IHapogasStrategia hs;
        IRepulesStrategia rs;

        public KonkretKacsa(IHapogasStrategia hs, IRepulesStrategia rs)
        {
            this.hs = hs;
            this.rs = rs;
        }

        public override void Hapogas()
        {
            this.hs.Hapogas();
        }

        public override void Repul()
        {
            this.rs.Repul();
        }
    }
}
