using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogApp.Controllers
{
    //[Route("[controller]")]
    public class PostsController : Controller
    {
        private readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Posts.ToList());
        }
    }
}