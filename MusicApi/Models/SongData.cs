using System;
using System.Collections.Generic;

namespace MusicApi.Models
{
    public partial class SongData
    {
        public SongData()
        {
            TblSong = new HashSet<Song>();
        }

        public int SongDataId { get; set; }
        public byte[] Data { get; set; }

        public ICollection<Song> TblSong { get; set; }
    }
}
