using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1NHF_D2P0JX
{
    class Kiir
    {
        private int biztonsagosszakasz = 0;
        private int veszelyesszakasz = 0;
        private int[,] biztonsagosszakaszok;
        private int[,] veszelyesszakaszok;
        private int b = 0;
        private int v = 0;
        private bool voltnulla = false;
        private bool voltketto = false;

        private void Meghataroz(int[] osszes)
        {
            int N = osszes.Length;
            biztonsagosszakaszok = new int[N, 2];
            veszelyesszakaszok = new int[N, 2];
            for (int i = 0; i < N; i++)
            {

                if (osszes[i] == 0)
                {
                    if (voltnulla == true && i == N - 1)
                    {
                        biztonsagosszakaszok[b, 1] = N;
                    }
                    else if (!voltnulla)
                    {
                        voltnulla = true;
                        biztonsagosszakasz += 1;
                        biztonsagosszakaszok[b, 0] = i + 1;
                    }
                }
                else if (osszes[i] == 2)
                {
                    if (voltketto == true && i == N - 1)
                    {
                        veszelyesszakaszok[b, 1] = N;
                    }
                    else if (!voltketto)
                    {
                        voltketto = true;
                        veszelyesszakasz += 1;
                        veszelyesszakaszok[v, 0] = i + 1;
                    }

                }
                else //az adott, nem 0 és nem 2 értékű napot megelőző napon volt már 0 vagy 2?
                {
                    if (i != 0 && osszes[i - 1] == 0)
                    {

                        voltnulla = false;
                        biztonsagosszakaszok[b, 1] = i;
                        b++;

                    }
                    else if (i != 0 && osszes[i - 1] == 2 )
                    {
                        voltketto = false;
                        veszelyesszakaszok[v, 1] = i;
                        v++;
                    }

                }
            }
        }

        public void FajlbaKiir(int[] osszes)
        {
            Meghataroz(osszes);
            StreamWriter sw = new StreamWriter("rendszer.ki.txt", false, Encoding.Default);
            sw.WriteLine(biztonsagosszakasz);
            for (int i = 0; i < osszes.Length; i++)
            {
                if (biztonsagosszakaszok[i, 0] != 0 && biztonsagosszakaszok[i, 1] != 0)
                {
                    sw.WriteLine(biztonsagosszakaszok[i, 0] + " " + biztonsagosszakaszok[i, 1]);
                }
            }
            sw.WriteLine(veszelyesszakasz);
            for (int i = 0; i < osszes.Length; i++)
            {
                if (veszelyesszakaszok[i, 0] != 0 && veszelyesszakaszok[i, 1] != 0)
                {
                    sw.WriteLine(veszelyesszakaszok[i, 0] + " " + veszelyesszakaszok[i, 1]);
                }
            }
            sw.Close();
        }
    }
}
