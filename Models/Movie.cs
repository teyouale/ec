using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ec.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
