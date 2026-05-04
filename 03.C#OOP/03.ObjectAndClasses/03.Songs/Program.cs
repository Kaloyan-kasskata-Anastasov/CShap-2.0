using System;
using System.Collections.Generic;
using System.Linq;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

class Program
{
    static void Main()
    {
        int numSongs = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < numSongs; i++)
        {
            string[] data = Console.ReadLine().Split('_');
            songs.Add(new Song
            {
                TypeList = data[0],
                Name = data[1],
                Time = data[2]
            });
        }

        string filter = Console.ReadLine();

        if (filter == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs.Where(s => s.TypeList == filter))
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}
