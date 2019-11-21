using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        private List<Album> GetAlbums(int id)
        {
            return db.Albums.Where(a => a.GenreId.Equals(id)).ToList();
        }
        public ActionResult Index(int id)
        {
            var albumlist = GetAlbums(id);
            return View(albumlist);
        }

        private List<Album> GetAlbum(int id)
        {
            return db.Albums.Where(a => a.AlbumId.Equals(id)).ToList();
        }
        public ActionResult Details(int id)
        {
            var album = GetAlbum(id);
            return View(album);
        }

        private List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }
        public ActionResult Browse()
        {
            var genrelist = GetGenres();
            return View(genrelist);
        }
    }
}