using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class AlbumPicture
    {
        public AlbumPicture()
        {
            TblAlbum = new HashSet<Album>();
        }

        public int AlbumPictureId { get; set; }
        public byte[] PictureOne { get; set; }
        public byte[] PictureTwo { get; set; }

        public ICollection<Album> TblAlbum { get; set; }
    }
}
