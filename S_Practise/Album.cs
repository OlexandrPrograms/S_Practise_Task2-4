using System;
using System.Collections.Generic;
using System.Text;

namespace S_Practise
{
    internal class Song
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Genre { get; set; }

        public Song(string title, int duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Duration: {Duration} minutes, Genre: {Genre}";
        }
    }

    internal class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Studio { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string title, string artist, int year, int duration, string studio, List<Song> songs)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Duration = duration;
            Studio = studio;
            Songs = songs;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {Title}, Artist: {Artist}, Year: {Year}, Duration: {Duration} minutes, Studio: {Studio}");
            sb.AppendLine("Songs:");
            foreach (var song in Songs)
            {
                sb.AppendLine($"  - {song}");
            }
            return sb.ToString();
        }
    }
}
