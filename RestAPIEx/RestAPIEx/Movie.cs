using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIEx
{
    public class Movie
    {
        public string title { get; set; }
        public string image { get; set; }
        public double rating { get; set; }
        public int releaseYear { get; set; }
        public List<string> genre { get; set; }
    }

}
