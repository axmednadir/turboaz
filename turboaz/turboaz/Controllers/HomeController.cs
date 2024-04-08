using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Claims;
using turboaz.Models;

namespace turboaz.Controllers
{
    public class HomeController : Controller
    {
        private readonly turboazContext _sql;
        public HomeController(turboazContext sql)
        {
            _sql = sql;
        }
        public IActionResult Index( int minprice , int maxprice, int minyear, int maxyear, string model, string seher,int page=0)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_sql.Cars.Count()/4);
            var data = _sql.Cars.Include(x => x.Photos).Where(x => x.CarTestiq == "tesdiqlendi").Where(x => 1 == 1);
            if (minprice != 0)
            {
                data = data.Where(x => x.CarQiy > minprice && x.CarTestiq == "tesdiqlendi");
            }
            if (maxprice != 0)
            {
                data = data.Where(x => x.CarQiy < maxprice && x.CarTestiq == "tesdiqlendi");
            }
            if (minyear != 0)
            {
                data = data.Where(x => x.CarIl > minyear && x.CarTestiq == "tesdiqlendi");
            }
            if (maxyear != 0)
            {
                data = data.Where(x => x.CarIl < maxyear && x.CarTestiq == "tesdiqlendi");
            }

            if (model != null)
            {
                data = data.Where(x => x.CarModel.Contains(model) && x.CarTestiq == "tesdiqlendi");
            }
            if (seher != null)
            {
                data = data.Where(x => x.CarSeher.Contains(seher) && x.CarTestiq == "tesdiqlendi");
            }
            ViewBag.Category = _sql.CategoryMarkas.Include(x => x.Cars).ToList();
            return View(data.OrderByDescending(x => x.CarId).Include(x => x.CarcategoryMarka).Skip(page*4).Take(4).ToList());
        }
        public IActionResult Add()
        {
            ViewBag.Category = _sql.CategoryMarkas.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Car c, IFormFile[] carImg)
        {
            _sql.Cars.Add(c);
            _sql.SaveChanges();
            foreach (var item in carImg)
            {
                if (carImg != null)
                {
                    string filename = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".png";
                    using (Stream stream = new FileStream("wwwroot/img/" + filename, FileMode.Create))
                    {
                        item.CopyTo(stream);
                    }
                    Photo p = new Photo();
                    p.PhotoUrl = filename;
                    p.PhotoCarId = c.CarId;
                    _sql.Photos.Add(p);
                }
            }
            c.CarUserId = int.Parse(@User.FindFirst(ClaimTypes.Sid).Value);
            c.CarTestiq = "tesdiqlenmedi";
            ViewBag.Category = new SelectList(_sql.CategoryMarkas.ToList(), "CategoryMarkaId", "CategoryMarkaName");
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int id)
        {
            var a = _sql.Cars.SingleOrDefault(x => x.CarId == id);
            _sql.Cars.Remove(a);
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var a = _sql.Cars.Include(x => x.Photos).SingleOrDefault(x => x.CarId == id);
            ViewBag.Category = _sql.CategoryMarkas.ToList();
            return View(a);
        }
        [HttpPost]
        public IActionResult Edit(int id, Car car, IFormFile[] carImg)
        {
            var old = _sql.Cars.SingleOrDefault(x => x.CarId == id);
            foreach (var item in carImg)
            {
                if (carImg != null)
                {
                    string filename = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + ".png";
                    using (Stream stream = new FileStream("wwwroot/img/" + filename, FileMode.Create))
                    {
                        item.CopyTo(stream);
                    }
                    Photo p = new Photo();
                    p.PhotoUrl = filename;
                    p.PhotoCarId = id;
                    _sql.Photos.Add(p);
                }
            }
            car.CarTestiq = "tesdiqlenmedi";
            old.CarDesciption = car.CarDesciption;
            old.CarQiy = car.CarQiy;
            old.CarId = id;
            old.CarModel = car.CarModel;
            old.CarIl = car.CarIl;
            old.CarUsername = car.CarUsername;
            old.CarSeher = car.CarSeher;
            old.CarTestiq = car.CarTestiq;
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Readmore(int id)
        {
            var a = _sql.Cars.Include(x => x.Photos).SingleOrDefault(x => x.CarId == id);
            return View(a);
        }

        public IActionResult Tesdiqlenmeyen()
        {
            ViewBag.Category = _sql.CategoryMarkas.Include(x => x.Cars).ToList();

            return View(_sql.Cars.Include(x => x.Photos).Where(x => x.CarTestiq == "tesdiqlenmedi").ToList());
        }
        public IActionResult Tesdiqle(int id)
        {
            var a = _sql.Cars.SingleOrDefault(x => x.CarId == id);
            a.CarTestiq = "tesdiqlendi";
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Istifadeci()
        {
            return View(_sql.Users.ToList());
        }
        public IActionResult IstifadeciRemove(int id)
        {
            var elanlar = _sql.Cars.Where(x => x.CarUserId == id).ToList();
            var istifadeci = _sql.Users.SingleOrDefault(x => x.UserId == id);
            _sql.Cars.RemoveRange(elanlar);
            _sql.Users.Remove(istifadeci);
            _sql.SaveChanges();
            return RedirectToAction("Istifadeci", "Home");
        }
        public IActionResult Myprofile(int id)
        {
            var elanlar = _sql.Cars.Where(x => x.CarUserId == id).ToList();

            return View(elanlar);
        }
        public IActionResult Deleteimg(int id)
        {
            Photo p = _sql.Photos.SingleOrDefault(x => x.PhotoId == id);
            _sql.Photos.Remove(p);
            _sql.SaveChanges();
            return RedirectToAction("Edit", new { id = p.PhotoCarId });
        }

    }

}
