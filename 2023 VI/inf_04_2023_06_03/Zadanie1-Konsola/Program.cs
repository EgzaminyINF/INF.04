using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/************************************************************
 * nazwa klasy: Film
 * pola: tytul - przechowuje tytuł filmu
 *       liczbaWypozyczen - przechowuje ilość wypożyczeń filmu
 * metody:      setTytul - brak
 *              getTytul - zwraca tytuł filmu
 *              zwiekszLiczbeWypozyczen - brak
 *              getLiczbaWypozyczen - zwraca liczbę wypożyczeń
 * informacje: stworzony jest obiekt film1 i na nim uruchamiane są metody
 * autor: PESEL
 ***********************************************************/
namespace Zadanie1_Konsola
{
    class Film
    {
        protected string tytul;
        protected int liczbaWypozyczen;
        public Film()
        {
            tytul = "";
            liczbaWypozyczen = 0;
        }
        public void setTytul(string nowyTytul)
        {
            if (nowyTytul.Length <= 20)
            {
                tytul = nowyTytul;
            }
            else
            {
                Console.WriteLine("Tytuł może mieć maksymalnie 20 znaków");
            }
        }
        public string getTytul()
        {
            return tytul;
        }
        public void zwiekszLiczbeWypozyczen()
        {
            liczbaWypozyczen++;
        }
        public int getLiczbaWypozyczen()
        {
            return liczbaWypozyczen;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Film film1 = new Film();
            Console.WriteLine("Tytuł: " + film1.getTytul());
            Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());

            film1.setTytul("Titanic");
            Console.WriteLine("Nowy tytul: " + film1.getTytul());

            Console.WriteLine("Pobrany tytuł: " + film1.getTytul());
            Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());
            film1.zwiekszLiczbeWypozyczen();
            Console.WriteLine("Liczba wypożyczeń: " + film1.getLiczbaWypozyczen());

            Console.ReadKey();
        }
    }
}
