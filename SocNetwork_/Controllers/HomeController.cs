using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
                        dateTimePost = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"))
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
                    item.CommentingUsers = item.CommentingUsers.OrderBy(s => s.DateTime).ToList();
                    foreach (var item2 in item.CommentingUsers)
                    {
                        item2.CommentingUser = _userManager.FindByIdAsync(item2.CommentingUserId).Result;
                    }
                }

                friendsPost = friendsPost.OrderBy(s => s.dateTimePost).ToList();
                PostViewModel post = new PostViewModel()
                {
                    id = user.Id,
                    firstName = user.firstName,
                    lastName = user.lastName,
                    profilePicture = user.ProfilePicture,
                    post = friendsPost,
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
            foreach (var item in user.UserPictures)
            {
                item.LikedUsers = dbContext.LikedUsers.Where(m => m.UserPictureId == item.id).ToList();
                item.CommentingUsers = dbContext.CommentingUsers.Where(m => m.UserPictureId == item.id).ToList();
                item.CommentingUsers = item.CommentingUsers.OrderBy(s => s.DateTime).ToList();
                foreach (var item2 in item.CommentingUsers)
                {
                    item2.CommentingUser = _userManager.FindByIdAsync(item2.CommentingUserId).Result;
                }
                foreach (var item2 in item.LikedUsers)
                {
                    item2.LikedUser = _userManager.FindByIdAsync(item2.LikedUserId).Result;
                }
            }
            return View(user);
        }
        [HttpPost]
        public async Task<JsonResult> AddLike(int id, string PageName)
        {
            bool liked = false;
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            List<LikedUsers> likedUsers = dbContext.LikedUsers.Where(m => m.LikedUserId == user.Id).ToList();
            UserPictures userPicture = dbContext.UserPictures.Where(m => m.id == id).First();
            foreach (var item in likedUsers)
            {
                if (item.UserPictureId == id)
                {
                    liked = true;
                }
            }
            LikedUsers likedUser = new LikedUsers()
            {
                DateTime = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss")),
                LikedUser = user,
                LikedUserId = user.Id,
                UserPictureId = id,
                UserPictures = userPicture,
                ApplicationUserId = userPicture.ApplicationUserId,
            };
            if (liked == true)
            {
                LikedUsers dislake = likedUsers.Where(m => m.UserPictureId == id).First();
                dbContext.LikedUsers.Remove(dislake);
            }
            else
            {
                dbContext.LikedUsers.Add(likedUser);
            }
            dbContext.SaveChanges();
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            var post = dbContext.UserPictures.Where(m => m.id == id).First();
            post.LikedUsers = dbContext.LikedUsers.Where(m => m.UserPictureId == id).ToList();
            // int x = likedCount2.LikedUsers.Count;
            return Json(post.LikedUsers.Count);
        }
        [HttpPost]
        public async Task<JsonResult> AddComment(int id, string comment, string PageName)
        {
            string host = httpContextAccessor.HttpContext.Request.Host.Value;

            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            //  PageName = PageName.Remove(PageName.Length - 7, 7);
            UserPictures userPicture = dbContext.UserPictures.Where(m => m.id == id).First();
            if (comment != null)
            {
                CommentingUsers commentingUser = new CommentingUsers()
                {
                    DateTime = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss")),
                    CommentingUser = user,
                    CommentingUserId = user.Id,
                    UserPictureId = id,
                    UserPictures = userPicture,
                    Comment = comment,
                    ApplicationUserId = userPicture.ApplicationUserId,
                };
                dbContext.CommentingUsers.Add(commentingUser);
                await dbContext.SaveChangesAsync();
            }
            object responseData = new
            {
                commentigUserId= user.Id,
                firstName = user.firstName,
                lastName = user.lastName,
                profilePicture = user.ProfilePicture,
                id = user.Id,
                dataTime = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss")),
                comment = comment
            };
            //return View("UserViewPage", userPicture.ApplicationUserId);
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