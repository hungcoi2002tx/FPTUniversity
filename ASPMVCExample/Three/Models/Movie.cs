using System;
using System.Collections.Generic;

namespace Three.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = null!;
        public decimal Price { get; set; }
        public string Rating { get; set; } = null!;
    }
}
