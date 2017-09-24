using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordedForKaraoke = Console.ReadLine().Split(new char[] { ',', ' ' } , StringSplitOptions.RemoveEmptyEntries).ToList();
            var playlistSong = Console.ReadLine().Trim().Split(new char[] { ',' } , StringSplitOptions.RemoveEmptyEntries).ToList();

            var dict = new Dictionary<string, Dictionary<int, List<string>>>();
            int count = 1;
            var input = Console.ReadLine();

            playlistSong = playlistSong.Select(e => e.Trim()).ToList();
            while (input != "dawn")
            {
                var tokens = input.Split(',').ToList();
                var name = tokens[0].Trim();
                var song = tokens[1].Trim();
                var opinion = tokens[2].Trim();
                bool isFoundPerson = recordedForKaraoke.Contains(name);
                if (isFoundPerson)
                {
                    bool isFoundSong = playlistSong.Contains(song);
                    if (playlistSong.Contains(song))
                    {
                        if (!dict.ContainsKey(name))
                        {
                            dict[name] = new Dictionary<int, List<string>>();
                            dict[name].Add(count, new List<string>());
                        }
                        dict[name][count].Add(opinion);
                    }
                }
                input = Console.ReadLine();
            }
            if (dict.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            // var result = dict.OrderBy(x => x.Value.Keys).Distinct().ToList();
            var ex = dict.Values;
            var result = dict.OrderBy(e => e.Value.Values.Count).ThenBy(n => n.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var item in dict)
            {
                var awards = dict.Values;
                Console.Write("{0}: " , item.Key);
                foreach (var song in item.Value)
                {
                    var value = song.Value;
                    Console.WriteLine(value.Count);
                    Console.WriteLine(string.Join("\n" , value));
                }
            }
        }
    }
}
