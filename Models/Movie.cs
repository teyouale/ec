using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ec.Models
{
    public class Movie
    {
        [Key]
        public int Movie_Id { get; set; }
        public string Name { get; set; }
        public string sex { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<People> People { get; set; }

    }
}
