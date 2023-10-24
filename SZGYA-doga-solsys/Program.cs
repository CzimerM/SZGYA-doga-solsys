using System;
using System.Text;

namespace SZGYA_doga_solsys
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            var sr = new StreamReader("../../../src/solsys.txt",Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                bolygok.Add(new Bolygo(sr.ReadLine()));
            }
            Console.WriteLine("3.feladat");
            Console.WriteLine($"\t3.1: {bolygok.Count} bolygó van a naprendszerben");
            Console.WriteLine($"\t3.2: a naprendszerben egy bolygónak átlagosan {bolygok.Average(b => b.HoldSzam)} holdja van");
            Console.WriteLine($"\t3.3: a legnagyobb térfogatú bolygó a {bolygok.MaxBy(b => b.TerfogatArany).Nev}");
            Console.Write($"\t3.4 írd be a keresett bolygó nevét: ");
            string keresett = Console.ReadLine();
            bool van = bolygok.Find(b => b.Nev.ToLower() == keresett.ToLower()) != null;
            Console.WriteLine($"\t\t{(van ? "van ilyen bolygó a naprendszerben" : "sajnos nincs ilyen bolygó a naprendszerben")}");
            Console.Write($"\t3.5: Írj be egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            var tobbHold = bolygok.Where(b => b.HoldSzam > szam);
            Console.WriteLine($"\ta következő bolygóknak van {szam}-nál/nél több holdja:");
            Console.Write("\t\t");
            foreach (var b in tobbHold)
            {
                Console.Write($"{b.Nev}, ");
            }
        }
    }
}