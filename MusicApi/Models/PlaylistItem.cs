using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class PlaylistItem
    {
        public int PlaylistItemId { get; set; }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        public UserPlaylist Playlist { get; set; }
        public Song Song { get; set; }
    }
}
