using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[100];
            Random r = new Random();
            for (int i = 0; i < 100; i++) 
            { 
                liczby[i] = r.Next(0, 1001);
            }
            sortowanie(liczby);
            foreach (int i in liczby) 
            { 
                Console.Write($"{i}, ");
            }
        }
        static void sortowanie(int[] tablicaLiczb)
        {
            // sortowanie bąbelkowe
            bool zmiana;
            do
            {
                zmiana = false;
                for (int i = 0; i < tablicaLiczb.Length - 1; i++)
                {
                    if(tablicaLiczb[i] > tablicaLiczb[i + 1])
                    {
                        int temp = tablicaLiczb[i];
                        tablicaLiczb[i] = tablicaLiczb[i + 1];
                        tablicaLiczb[i + 1] = temp;
                        zmiana = true;
                    }
                }
            }while (zmiana);
        }
    }
}
