using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogApp.Controllers
{
    //[Route("[controller]")]
    public class PostsController : Controller
    {
        private IPostRepository _repository;

        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Posts.ToList());
        }
    }
}