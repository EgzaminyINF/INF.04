using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***********************************************
 * nazwa funkcji:       sitoEratostenes
 * parametry wjeściowe: tablica składająca się z wartości logicznych true
 * wartość zwracana:    brak
 * informacje:          aplikacja wyszukje liczby pierwsze w zbiorze 2..100
 * autor:               PESEL
 * *********************************************/
namespace Zadanie1Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            bool[] pierwsze = new bool[n + 1];

            sitoEratostenes(pierwsze);
            wyswietlPierwsze(pierwsze);

            Console.ReadKey();
        }
        static void sitoEratostenes(bool[] pierwsze)
        {
            int n = pierwsze.Length - 1;
            double sqrtP = Math.Sqrt(n);
            // inicjalizacja tablicy
            for (int i = 0; i <= n; i++)
            {
                pierwsze[i] = true;
            }
            // Sito Eratostenes
            for (int i = 2;i <= sqrtP; i++)
            {
                if (pierwsze[i])
                {
                    for (int j = i * i;  j <= n; j += i)
                    {
                        pierwsze[j] = false;
                    }
                }
            }
        }
        static void wyswietlPierwsze(bool[] pierwsze)
        {
            for(int i = 2; i < pierwsze.Length; i++)
            {
                if (pierwsze[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
