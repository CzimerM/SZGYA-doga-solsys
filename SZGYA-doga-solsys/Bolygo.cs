using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_doga_solsys
{
    class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzam { get; set; }
        public float TerfogatArany { get; set; }

        public Bolygo(string sor) 
        {
            string[] adatok = sor.Split(';');
            this.Nev = adatok[0];
            this.HoldSzam = int.Parse(adatok[1]);
            this.TerfogatArany = float.Parse(adatok[2].Replace('.',','));
        }
    }
}
