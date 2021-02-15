using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListaPrimjer
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            // Dodajemo elemente u kolekciju
            al.Add(4);
            al.Add("C# i .NET");
            al.Insert(1, "Programiranje");
            Console.WriteLine("--Elementi kolekcije na početku:");

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            if (al.Contains(4))
            {
                al.Remove(4);
            }

            int pozicija = al.IndexOf("Programiranje");

            if (pozicija >= 0)
            {
                al.RemoveAt(pozicija);
            }
            Console.WriteLine("\n-- Elementi kolekcije na završetku:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
        }
    }
}