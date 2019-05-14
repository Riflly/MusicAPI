using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MusicApi.Models
{
    public class CreateArtistModel
    {
        [Required]
        [Display(Name="Artist Name")]
        public string ArtistName { get; set; }
        [Display(Name = "Artist Bio")]
        public string ArtistBio { get; set; }
        [Required]
        [Display(Name = "Picture One")]
        public IFormFile PictureOne { get; set; }
        [Display(Name = "Picture Two")]
        public IFormFile PictureTwo { get; set; }
    }
}
