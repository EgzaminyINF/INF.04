using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************************
 * nazwa:       funkcja nazywa się losowanie
 * opis:        funkcja losuje ilość liczb wskazanych przez użytkownika od 1 do 6
 * parametry:   ilerazy typu integer
 * 
 * zwracany typ i opis: zwracana jest tablica wylosowanych liczb 
 * autor: 00000000000
 * **********************************/
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iloscKostek, suma;
            char znak = 't';
            do
            {
                Console.WriteLine("Ile kostek chcesz rzucić?(3-10)");
                iloscKostek = int.Parse(Console.ReadLine());
                int[] zbiorLiczb = new int[iloscKostek];
                if (iloscKostek >= 3 && iloscKostek <= 10)
                {
                    zbiorLiczb = losowanie(iloscKostek);
                    suma = 0;
                    Array.Sort(zbiorLiczb);
                    int aktualnaLiczba = zbiorLiczb[0];
                    for (int j = 1; j < iloscKostek; j++)
                    {
                        if(aktualnaLiczba == zbiorLiczb[j])
                        {
                            if (j < iloscKostek - 1 && zbiorLiczb[j] == zbiorLiczb[j + 1])
                                suma += zbiorLiczb[j];
                            else
                                suma += aktualnaLiczba + zbiorLiczb[j];
                        }
                        else
                        {
                            aktualnaLiczba = zbiorLiczb[j];
                        }
                    }
                    Console.WriteLine($"Liczba uzyskanych punktów: {suma}");
                    Console.WriteLine("Jeszcze raz? (t/n)");
                    znak = char.Parse(Console.ReadLine());
                }
            }while (znak == 't');
        }
        static int[] losowanie(int ilerazy)
        {
            Random rand = new Random();
            int[] liczba = new int[ilerazy];
            for (int i = 1; i <= ilerazy; i++)
            {
                liczba[i - 1] = rand.Next(1, 7);
                Console.WriteLine($"Kostka {i}: {liczba[i - 1]}");
            }
            return liczba;
        }
    }
}
