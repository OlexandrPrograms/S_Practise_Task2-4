using System;
using System.Collections.Generic;
using System.Text;

namespace S_Practise
{
    internal class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public string Studio { get; set; }

        public Album(string title, string artist, int year, int duration, string studio)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Duration = duration;
            Studio = studio;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Year: {Year}, Duration: {Duration} minutes, Studio: {Studio}";
        }
    }
}
