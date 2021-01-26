using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1NHF_D2P0JX
{
    class Szabadnapok
    {
        private int[] napok;

        public int[] Napok
        {
            get
            {
                return napok;
            }
        }

        public void NapokFeltolt(int N)
        {
            napok = new int[N];
            for (int i = 0; i < napok.Length; i++)
            {
                napok[i] = 0;
            }
        }

        public void Beoszt(int[,] beosztottak, int hossz)
        {
            for (int i = 0; i < hossz; i++)
            {
                int mettol = (beosztottak[i, 0]) - 1;
                do
                {
                    napok[mettol] += 1;
                    mettol += 1;
                }
                while (mettol < beosztottak[i, 1]);
            }

        }

    }
}
