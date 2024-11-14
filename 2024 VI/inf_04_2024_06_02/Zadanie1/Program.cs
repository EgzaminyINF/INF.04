using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************
 * nazwa funkcji:   wyswietl albumy
 * opis funkcji:    funkcja ma na celu wypisać z listy albumy
 * parametry:       jest lista z klasy Albumy
 * 
 * zwracany typ:    zwraca zapisane albumy do listy z pliku tekstowego
 * autor:           0000000000
 * ************************/
namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Album> albums = ReadAlbumFromFile("Data.txt");
            wyswietlAlbumy(albums);
        }
        private static List<Album> ReadAlbumFromFile(string file)
        {
            List<Album> albums = new List<Album>();
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                string parts;
                while((line = reader.ReadLine()) != null)
                {
                    parts = line;
                    Album album = new Album();
                    album.artist = parts;
                    album.album = reader.ReadLine();
                    album.songsNumber = uint.Parse(reader.ReadLine());
                    album.year = uint.Parse(reader.ReadLine());
                    album.downloadNumber = ulong.Parse(reader.ReadLine());
                    album.nowaLinia = reader.ReadLine();
                    albums.Add(album);
                }
            }
            return albums;
        }
        private static void wyswietlAlbumy(List<Album> albums)
        {
            foreach (Album album in albums)
            {
                Console.WriteLine(album.artist);
                Console.WriteLine(album.album);
                Console.WriteLine(album.songsNumber);
                Console.WriteLine(album.year);
                Console.WriteLine(album.downloadNumber);
                Console.WriteLine(album.nowaLinia);
            }
        }
        class Album
        {
            public string artist {  get; set; }
            public string album {  get; set; }
            public uint songsNumber { get; set; }
            public uint year {  get; set; }
            public ulong downloadNumber { get; set; }
            public string nowaLinia { get; set; }
        }
    }
}
