using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicApi.Infrastructure;

namespace MusicApi.Models
{
    public class EFProductRepository : IProductRepo
    {
        public MusicAPIsContext context;
        public EFProductRepository(MusicAPIsContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Album> Albums => context.TblAlbum;

        public IQueryable<AlbumPicture> AlbumPictures => context.TblAlbumPicture;
    }
}
