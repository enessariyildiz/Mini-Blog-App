using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Entities;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogApp.Controllers
{
    //[Route("[controller]")]
    public class PostsController : Controller
    {
        private IPostRepository _postRepository;
        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View(
                new PostsViewModel
                {
                    Posts = _postRepository.Posts.ToList()
                   
                }
            );
        }
    }
}