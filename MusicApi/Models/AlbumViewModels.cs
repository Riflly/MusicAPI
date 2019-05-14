using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MusicApi.Models
{
    public class CreateAlbumModel
    {
        [Required]
        [Display(Name = "Album Name")]
        public string AlbumName { get; set; }
        [Required]
        [Display(Name = "Picture One")]
        public IFormFile PictureOne { get; set; }
        [Display(Name = "Picture Two")]
        public IFormFile PictureTwo { get; set; }
        [Required]
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        [Required]
        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}
