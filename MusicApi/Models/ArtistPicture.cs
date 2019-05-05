using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class ArtistPicture
    {
        public ArtistPicture()
        {
            TblArtist = new HashSet<Artist>();
        }

        public int ArtistPictureId { get; set; }
        public byte[] PictureOne { get; set; }
        public byte[] PictureTwo { get; set; }

        public ICollection<Artist> TblArtist { get; set; }
    }
}
