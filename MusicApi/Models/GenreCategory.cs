using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class GenreCategory
    {
        public GenreCategory()
        {
            TblAlbum = new HashSet<Album>();
            TblUser = new HashSet<User>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public ICollection<Album> TblAlbum { get; set; }
        public ICollection<User> TblUser { get; set; }
    }
}
