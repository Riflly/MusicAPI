using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class Song
    {
        public Song()
        {
            TblPlaylistItem = new HashSet<PlaylistItem>();
        }

        public int SongId { get; set; }
        public string SongName { get; set; }
        public int? TrackNum { get; set; }
        public int? SongDataId { get; set; }
        public int AlbumId { get; set; }
        public string VideoLink { get; set; }

        public Album Album { get; set; }
        public SongData SongData { get; set; }
        public ICollection<PlaylistItem> TblPlaylistItem { get; set; }
    }
}
