using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1NHF_D2P0JX
{
    class Beolvasas
    {
        
        public void Beolvas(Beosztas rszgelso, Beosztas rszgmasodik, Szabadnapok rendszergazdak)
        {
            StreamReader sr = new StreamReader("rendszer.be.txt", Encoding.Default);

            //teszteléshez (a kimeneti fájl minden esetben ugyanaz marad):
            //StreamReader sr = new StreamReader("teszt1.txt", Encoding.Default);  //-az első és az utolsó napon is van valakinek szabadnapja
            //StreamReader sr = new StreamReader("teszt2.txt", Encoding.Default);  //-futásidejű hiba tesztelése
            //StreamReader sr = new StreamReader("teszt3.txt", Encoding.Default);  //-az egyiküknek egyáltalán nincs szabadnapja
            //StreamReader sr = new StreamReader("teszt4.txt", Encoding.Default);  //-mindketten minden nap szabadságon vannak
            int N = int.Parse(sr.ReadLine());
            rendszergazdak.NapokFeltolt(N);
            int K = int.Parse(sr.ReadLine());
            rszgelso.Feltolt(K, sr);
            int L = int.Parse(sr.ReadLine());
            rszgmasodik.Feltolt(L, sr);
            rendszergazdak.Beoszt(rszgelso.Szabik, K);
            rendszergazdak.Beoszt(rszgmasodik.Szabik, L);
        }
    }
}
