using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1NHF_D2P0JX
{
    class Beosztas
    {
        private int[,] szabik;
        public int[,] Szabik
        {
            get
            {
                return szabik;
            }
        }

        public void Feltolt(int K, StreamReader sr)
        {
            szabik = new int[K, 2];
            for (int i = 0; i < K; i++)
            {
                string beolvas = sr.ReadLine();
                string[] mettolmeddig = beolvas.Split(' ');
                szabik[i, 0] = int.Parse(mettolmeddig[0]);
                szabik[i, 1] = int.Parse(mettolmeddig[1]);
            }
        }
    }
}
