using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KidsFair
{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Starting the album program"); //Start message
            Console.WriteLine(); //blankline

            ReadAndSaveAlbumData();
            DisplayAlbumInfo();
        }
             public void ReadAndSaveAlbumData() //Album Data
             {
              //Read album name
              Console.Write("What is the name of your favourite album?");
              albumName = Console.ReadLine();

              //Read artist name
              Console.WriteLine("What is the name of the Artist or Band of " + albumName + "?");
              artistName = Console.ReadLine();

              //Read number of tracks
              Console.WriteLine("How many tracks does " + albumName + " have?");
              string textValueTracks = Console.ReadLine();
              //convert string to number
              numOfTracks = int.Parse(textValueTracks);
             }
                 public void DisplayAlbumInfo()
                 {
                  string s = "Album name:" + albumName + ".Artist/Band name:" + artistName + ".Number of tracks:" + numOfTracks;
                  //Console.WriteLine("Artist/Band name:" + artistName);
                  //Console.WriteLine("Number of tracks:" + numOfTracks);
                  s = s.Replace(".", "." + Environment.NewLine);
                  Console.WriteLine(s);
                 }
    }
}
