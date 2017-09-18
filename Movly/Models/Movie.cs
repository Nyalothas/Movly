﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Movly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20,ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        public byte NumberInStoc { get; set; }

    }
}