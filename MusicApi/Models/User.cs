using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class User
    {
        public User()
        {
            TblUserPlaylist = new HashSet<UserPlaylist>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPasswordHash { get; set; }
        public string UserEmail { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? FavGenreId { get; set; }
        public bool? IsAdmin { get; set; }

        public GenreCategory FavGenre { get; set; }
        public ICollection<UserPlaylist> TblUserPlaylist { get; set; }
    }
}
