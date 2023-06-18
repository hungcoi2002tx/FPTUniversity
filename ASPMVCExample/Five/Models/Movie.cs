using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Five.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; } = null!;
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = null!;
        public decimal Price { get; set; }
        public string Rating { get; set; } = null!;
    }
}
