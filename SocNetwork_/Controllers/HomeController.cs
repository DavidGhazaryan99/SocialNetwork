using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.ModelDto;
using SocNetwork_.Models;
using SocNetwork_.Service;
using SocNetwork_.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ServiceLogic _serviceLogic;

        public HomeController(ServiceLogic ServiceLogic, ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
        {
            _serviceLogic = ServiceLogic;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<ActionResult> Index(string textForPost, IFormFile postFile)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                if (textForPost != null && postFile != null)
                {
                    await _serviceLogic.CreatePost(textForPost, postFile, user);
                }

                var posts = await _serviceLogic.GetPosts(user, userId);

                return View(posts);
            }
            else
                return View();
        }
        [HttpPost]
        public IActionResult AddNews(IFormFile image)
        {
            ApplicationUser tbl_News = new ApplicationUser();
            if (image != null)
            {

                //Set Key Name
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);

                //Get url To Save
                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", ImageName);

                using (var stream = new FileStream(SavePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
            }
            return View();
        }

        public async Task<IActionResult> Photos()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            user.UserPictures = await _serviceLogic.GetPhotos(userId);

            return View(user);
        }

        [HttpPost]
        public async Task<JsonResult> AddLike(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var postSrv = await _serviceLogic.AddLike(userId, id);

            return Json(postSrv.LikedUsers.Count);
        }
        [HttpPost]
        public async Task<JsonResult> AddComment(int id, string comment)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            CommentDto responseData = await _serviceLogic.AddComment(userId, id, comment);
            return Json(responseData);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}