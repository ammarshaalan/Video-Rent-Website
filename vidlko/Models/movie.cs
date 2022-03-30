using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using vidlko.DTOs;

namespace vidlko.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public DateTime DateAdded { get; set; }

        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }


    }
}