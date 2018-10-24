using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public Genres Genre { get; set; }
    }
}