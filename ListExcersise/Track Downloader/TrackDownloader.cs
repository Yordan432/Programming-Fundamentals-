using System;
using System.Collections.Generic;
using System.Linq;

class TrackDownloader
{
    static void Main()
    {
        List<string> blacklistedSong = Console.ReadLine().Split(' ').ToList();
       
        int indexSong = 0;
        int indexBlackSong = 0;
        List<string> songs = Console.ReadLine().Split(' ').ToList();
        while (songs[0] != "end")
        {
            var firstElementFromBlackSong = blacklistedSong[indexBlackSong];
            var firstElementFromSong = songs[indexSong];

            if (firstElementFromBlackSong == firstElementFromSong)
            {
                songs.Remove(songs[indexSong]);
            }

            songs = Console.ReadLine().Split(' ').ToList();
           // indexSong++;
        }
    }
}

