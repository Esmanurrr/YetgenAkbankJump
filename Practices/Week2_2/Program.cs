

using Microsoft.VisualBasic;
using Week2_2.Entities;
using Week2_2.Services;

var song1 = new Song("Requiem K. 626", "W. A. Mozart", "Orchestre national de France", null);
var song2 = new Song("Sonata No.6 in F Major", "L. Beethoven", "Fazıl Say", "Warner Music");
var song3 = new Song("Moonlight Sonata", "Ludwig van Beethoven", "Various Artist", "Classical Records");
var song4 = new Song("The Four Seasons", "Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");
var song5 = new Song("Symphony No. 9", "Ludwig van Beethoven", "Philharmonic Orchestra", "Classic Harmony Records");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before Shuffle : ");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle : ");
Console.WriteLine(playlist1.GetSongs());

