using homework_08._09._2022.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace homework_08._09._2022.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> pro = new List<Product>();
            pro.Add(new Product { id = 1, name = "mehsul1", price = 54, rating = 4, imageUrl1 = "p24.jpg", imageUrl2 = "p25.jpg" });
            pro.Add(new Product { id = 2, name = "mehsul2", price = 34, rating = 4, imageUrl1 = "p24.jpg", imageUrl2 = "p25.jpg" });
            pro.Add(new Product { id = 3, name = "mehsul3", price = 87, rating = 3, imageUrl1 = "p24.jpg", imageUrl2 = "p25.jpg" });
            pro.Add(new Product { id = 4, name = "mehsul4", price = 21, rating = 1, imageUrl1 = "p24.jpg", imageUrl2 = "p25.jpg" });
            pro.Add(new Product { id = 5, name = "mehsul5", price = 34, rating = 2, imageUrl1 = "p24.jpg", imageUrl2 = "p25.jpg" });
            return View(pro);
        }
    }
}
