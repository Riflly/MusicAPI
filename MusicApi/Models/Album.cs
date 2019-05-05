using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class Album
    {
        public Album()
        {
            TblSong = new HashSet<Song>();
        }

        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public int? AlbumPictureId { get; set; }
        public int? ReleaseYear { get; set; }
        public int? GenreId { get; set; }
        public int? ArtistId { get; set; }

        public AlbumPicture AlbumPicture { get; set; }
        public Artist Artist { get; set; }
        public GenreCategory Genre { get; set; }
        public ICollection<Song> TblSong { get; set; }
    }
}
