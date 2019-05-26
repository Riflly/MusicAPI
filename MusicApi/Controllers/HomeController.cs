using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Infrastructure;
using MusicApi.Models;

namespace MusicApi.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepo repo;

        public HomeController(IProductRepo repository)
        {
            repo = repository;
        }
        public ActionResult Index()
        {
            return View(repo.Albums.Include(p => p.AlbumPicture).Include(a => a.Artist));
        }

        public ViewResult UserPlaylistCreate()
        {
            ViewData["UserIDs"] = Request.Cookies["UserID"];
            ViewBag.userIDs = Request.Cookies["UserID"];
            return View();
        }

        [HttpGet()]
        public ViewResult GetSongsView([FromQuery(Name = "com")] string albumName)
        {
            return View(new ListView
            {
                Songs = repo.Songs.Include(s => s.SongData).Include(a => a.Album).Include(apic => apic.Album.AlbumPicture).Include(art => art.Album.Artist).Where(name => name.Album.AlbumName.Equals(albumName)),
                UserPlaylists = repo.UserPlaylists
            });
        }

        [HttpGet()]
        public async Task<IActionResult> AddSongItem([FromQuery(Name = "playlistID")] string playlistID, [FromQuery(Name = "songName")] string songID)
        {
            PlaylistItem playlistItem = new PlaylistItem
            {
                PlaylistId = Int16.Parse(playlistID),
                SongId = Int16.Parse(songID)
            };

            bool result = await repo.CreatePlayListItem(playlistItem);

            if (result)
            {
                //return View("Index");
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["Error"] = "There was an Error";
            }
            return View("Index");

        }

        [HttpPost]
        public async Task<IActionResult> UserPlaylistCreate(UserPlaylist userPlaylist)
        {
            // Request.Cookies.
            // PlaylistId = context.TblUserPlaylist.Count() +1,
            if (ModelState.IsValid)
            {
                UserPlaylist playlist = new UserPlaylist
                {

                    PlaylistName = userPlaylist.PlaylistName,
                    PlaylistDesc = userPlaylist.PlaylistDesc,
                    UserId = userPlaylist.UserId
                    
                };
             //   string id = Request.Cookies["UserName"];

                //playlist.UserId = 1;

                bool result = await repo.CreateUserPlaylist(userPlaylist);
                if (result)
                {
                    //return View("Index");
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "An error occured while creating the UserPlaylist");
                }
            }
            return View(userPlaylist);
        }
    }
}