using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicApi.Models;

namespace MusicApi.Infrastructure
{
    public interface IProductRepo
    {
        IQueryable<Album> Albums { get; }
        IQueryable<AlbumPicture> AlbumPictures { get; }
        IQueryable<Artist> Artists { get; }
        IQueryable<ArtistPicture> ArtistPictures { get; }
        IQueryable<GenreCategory> Genres { get; }
        Task<bool> CreateArtistPicAsync(ArtistPicture artistPic);

        Task<bool> CreateArtistAsync(Artist artist);

        Task<bool> CreateAlbumPicAsync(AlbumPicture albumPic);

        Task<bool> CreateAlbumAsync(Album album);

        Task<bool> CreateSongAsync(Song song);

        Task<bool> CreateSongDataAsync(SongData songData);

    }
}
