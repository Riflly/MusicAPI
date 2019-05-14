using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models;
using MusicApi.Infrastructure;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MusicApi.Controllers
{
    public class CreateController : Controller
    {
        private IProductRepo repository;

        public CreateController(IProductRepo repo)
        {
            repository = repo;
        }

        public ViewResult CreateArtist() => View();
        public IActionResult CreateAlbum()
        {
            var genres = repository.Genres;
            var artists = repository.Artists;
            ViewBag.Genres = genres;
            ViewBag.Artists = artists;
            return View();
        }
        public IActionResult CreateSong()
        {

            var albums = repository.Albums ;
            ViewBag.Albums = albums;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist(CreateArtistModel model)
        {
            if (ModelState.IsValid)
            {
                ArtistPicture artistPicture = new ArtistPicture();

                using (var memoryStream = new MemoryStream())
                {
                    await model.PictureOne.CopyToAsync(memoryStream);
                    artistPicture.PictureOne = memoryStream.ToArray();
                    if(model.PictureTwo != null)
                    {
                        await model.PictureTwo.CopyToAsync(memoryStream);
                        artistPicture.PictureTwo = memoryStream.ToArray();
                    }
                }

                bool result = await repository.CreateArtistPicAsync(artistPicture);
                if (result)
                {
                    Artist artist = new Artist
                    {
                        ArtistName = model.ArtistName,
                        ArtistBio = model.ArtistBio,
                        ArtistPictureId = artistPicture.ArtistPictureId
                    };
                    result = await repository.CreateArtistAsync(artist);

                    if (result)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "An error occured while creating the Artist");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "An error occured while creating the adding the Artist pictures");
                }


            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAlbum(CreateAlbumModel model)
        {
            if (ModelState.IsValid)
            {
                AlbumPicture albumPicture = new AlbumPicture();

                using (var memoryStream = new MemoryStream())
                {
                    await model.PictureOne.CopyToAsync(memoryStream);
                    albumPicture.PictureOne = memoryStream.ToArray();
                    if (model.PictureTwo != null)
                    {
                        await model.PictureTwo.CopyToAsync(memoryStream);
                        albumPicture.PictureTwo = memoryStream.ToArray();
                    }
                }

                bool result = await repository.CreateAlbumPicAsync(albumPicture);
                if (result)
                {
                    Album album = new Album
                    {
                        AlbumName = model.AlbumName,
                        ArtistId = model.ArtistId,
                        GenreId = model.GenreId,
                        ReleaseYear = model.ReleaseYear,
                        AlbumPictureId = albumPicture.AlbumPictureId
                    };
                    result = await repository.CreateAlbumAsync(album);

                    if (result)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "An error occured while creating the Album");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "An error occured while creating the Album pictures");
                }


            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSong(CreateSongModel model)
        {
            if (ModelState.IsValid)
            {
                SongData songData = new SongData();

                using (var memoryStream = new MemoryStream())
                {
                    await model.SongData.CopyToAsync(memoryStream);
                    songData.Data = memoryStream.ToArray();
                }

                bool result = await repository.CreateSongDataAsync(songData);
                if (result)
                {
                    Song song = new Song
                    {
                        SongName = model.SongName,
                        TrackNum = model.TrackNum,
                        AlbumId = model.AlbumId,
                        SongDataId = songData.SongDataId,
                        VideoLink = model.VideoLink
                    };
                    result = await repository.CreateSongAsync(song);

                    if (result)
                    {
                        return RedirectToAction("CreateSong", "Create");
                    }
                    else
                    {
                        ModelState.AddModelError("", "An error occured while creating the Song");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "An error occured while creating the Song");
                }


            }
            return View(model);
        }
    }
}
