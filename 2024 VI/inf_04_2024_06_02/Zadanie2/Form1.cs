using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zadanie2.Form1;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        List<Album> albumy = new List<Album>();
        public int aktualnyIndex = 0;
        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Album album = new Album()
                    {
                        artist = line,
                        album = reader.ReadLine(),
                        songsNumber = uint.Parse(reader.ReadLine()),
                        year = uint.Parse(reader.ReadLine()),
                        downloadNumber = ulong.Parse(reader.ReadLine()),
                        nowaLinia = reader.ReadLine()
                    };
                    albumy.Add(album);
                }
            }
            aktualizujAlbum();
        }
        private void aktualizujAlbum()
        {
            Album aktualnyAlbum = albumy[aktualnyIndex];
            label1.Text = aktualnyAlbum.artist;
            label2.Text = aktualnyAlbum.album;
            label3.Text = aktualnyAlbum.songsNumber.ToString() + " utworów";
            label4.Text = aktualnyAlbum.year.ToString();
            label5.Text = aktualnyAlbum.downloadNumber.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            albumy[aktualnyIndex].downloadNumber++;
            aktualizujAlbum();
        }

        public class Album
        {
            public string artist { get; set; }
            public string album { get; set; }
            public uint songsNumber { get; set; }
            public uint year { get; set; }
            public ulong downloadNumber { get; set; }
            public string nowaLinia { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aktualnyIndex = (aktualnyIndex - 1 + albumy.Count) % albumy.Count;
            aktualizujAlbum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aktualnyIndex = (aktualnyIndex + 1) % albumy.Count;
            aktualizujAlbum();
        }
    }
}
