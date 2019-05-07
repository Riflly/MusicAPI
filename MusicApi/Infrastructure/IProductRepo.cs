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
    }
}
