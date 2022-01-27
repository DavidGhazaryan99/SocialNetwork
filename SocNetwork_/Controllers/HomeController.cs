using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.Models;
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
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public IActionResult Index(string textForPost, IFormFile postFile)
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                if (textForPost != null && postFile != null)
                {
                    UserPictures userPictures = new UserPictures()
                    {
                        textForPicture = textForPost,
                        Picture = UploadedFile(postFile),
                        ApplicationUser = user,
                        dateTimePost = DateTime.Now
                    };
                    dbContext.UserPictures.Add(userPictures);
                    dbContext.SaveChanges();
                    _userManager.UpdateAsync(user);
                    _signInManager.RefreshSignInAsync(user);
                }
                List<UserPictures> friendsPost = new List<UserPictures>();
                user.UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == userId).ToList();
                friendsPost.AddRange(user.UserPictures);
                List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();

                foreach (var item in friends)
                {
                    ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                    item.friendUser = friendUser;
                    item.friendUser.UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == item.friendUserId).ToList();
                }

                foreach (var item in friends)
                {
                    friendsPost.AddRange(item.friendUser.UserPictures);
                }

                foreach (var item in friendsPost)
                {
                    item.LikedUsers = dbContext.LikedUsers.Where(m => m.UserPictureId == item.id).ToList();
                    item.CommentingUsers = dbContext.CommentingUsers.Where(m => m.UserPictureId == item.id).ToList();
                    List<LikedUsers> likedCountUsers = dbContext.LikedUsers.Where(m => m.UserPictureId == item.id).ToList();
                }

                var friendsPostsOrder = friendsPost.OrderBy(s => s.dateTimePost).ToList();

                PostViewModel post = new PostViewModel()
                {
                    id = user.Id,
                    firstName = user.firstName,
                    lastName = user.lastName,
                    profilePicture = user.ProfilePicture,
                    post = friendsPostsOrder,
                };
                return View(post);
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


        public IActionResult Photos()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            user.UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == user.Id).ToList();
            return View(user);
        }


        public async Task<IActionResult> AddLike(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            UserPictures userPicture = dbContext.UserPictures.Where(m => m.id == id).First();
            LikedUsers likedUser = new LikedUsers()
            {
                DateTime = DateTime.Now,
                LikedUser = user,
                LikedUserId = user.Id,
                UserPictureId = id,
                UserPictures=userPicture,
                ApplicationUserId = userPicture.ApplicationUserId,
            };
            dbContext.LikedUsers.Add(likedUser);
            dbContext.SaveChanges();
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            return LocalRedirect("~/Home"); ;
        }
        public async Task<IActionResult> AddComment(int id,string comment)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            UserPictures userPicture = dbContext.UserPictures.Where(m => m.id == id).First();
            CommentingUsers commentingUser = new CommentingUsers()
            {
                DateTime = DateTime.Now,
                CommentingUser = user,
                CommentingUserId = user.Id,
                UserPictureId = id,
                UserPictures = userPicture,
                Comment = comment,
                ApplicationUserId = userPicture.ApplicationUserId,
            };
            dbContext.CommentingUsers.Add(commentingUser);
            dbContext.SaveChanges();
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            return LocalRedirect("~/Home"); ;
        }


        public IActionResult Chat()
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

        private string UploadedFile(IFormFile Picture)
        {
            var file = Picture;
            if (file.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string s = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                    return s;
                }
            }
            return null;
        }
    }
}
