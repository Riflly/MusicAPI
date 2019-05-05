using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class Artist
    {
        public Artist()
        {
            TblAlbum = new HashSet<Album>();
        }

        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string ArtistBio { get; set; }
        public int? ArtistPictureId { get; set; }

        public ArtistPicture ArtistPicture { get; set; }
        public ICollection<Album> TblAlbum { get; set; }
    }
}
