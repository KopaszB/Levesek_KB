using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Levesek_KB
{
    class Program
    {
        static Adatbazis db = new Adatbazis();
        static List<Leves> levesek = db.Leveslista();
        static void Main(string[] args)
        {
            /*
            foreach (Leves item in levesek)
            {
                Console.WriteLine(item.Megnevezes);
            }
            */
            feladat01();
            feladat02();
            feladat03();
            
            Console.ReadKey();
        }

        private static void feladat01()
        {
            Console.WriteLine($"Levesek száma: {levesek.Count}");
        }

        private static void feladat02()
        {
            int maxikal = levesek[0].Kaloria;
            int j = 0;
            for (int i = 0; i < levesek.Count; i++)
            {
                if (levesek[i].Kaloria > maxikal)
                {
                    maxikal = levesek[i].Kaloria;
                    j = i;
                }
            }
            Console.WriteLine($"A legtöbb kalóriát tartalmazó leves: {levesek[j].Megnevezes}");
        }

        private static void feladat03()
        {
            foreach (Leves item in levesek)
            {
                if (!item.Megnevezes.Contains("leves"))
                {
                    Console.WriteLine($"A következő levesek nevében nem szerepel a leves szó: {item.Megnevezes}");
                }
                
            }
        }

    }
}
