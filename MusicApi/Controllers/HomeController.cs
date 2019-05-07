using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApi.Infrastructure;

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
    }
}