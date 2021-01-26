using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1NHF_D2P0JX
{
    

    class Program
    {
        static void Main(string[] args)
        {
            
            Beolvasas bemenet = new Beolvasas();
            Szabadnapok rendszergazdak = new Szabadnapok();
            Beosztas rszgelso = new Beosztas();
            Beosztas rszgmasodik = new Beosztas();
            bemenet.Beolvas(rszgelso, rszgmasodik, rendszergazdak);
            Kiir eredmeny = new Kiir();
            eredmeny.FajlbaKiir(rendszergazdak.Napok);
        }
    }
}
