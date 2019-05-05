using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class UserPlaylist
    {
        public UserPlaylist()
        {
            TblPlaylistItem = new HashSet<PlaylistItem>();
        }

        public int PlaylistId { get; set; }
        public string PlaylistName { get; set; }
        public string PlaylistDesc { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
        public ICollection<PlaylistItem> TblPlaylistItem { get; set; }
    }
}
