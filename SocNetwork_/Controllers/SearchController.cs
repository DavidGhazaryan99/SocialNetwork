using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.Models;
using SocNetwork_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public SearchController(ILogger<SearchController> logger, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: SearchController
        public ActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            var allUsers = _userManager.Users.ToListAsync().Result;
            user.FriendsFrom = dbContext.FriendsRequest.Where(m => m.friendToId == user.Id).ToList();
            List<ApplicationUser> validUsers = new List<ApplicationUser>();
            for (int i = 0; i < allUsers.Count; i++)
            {
                for (int j = 0; j < user.FriendsFrom.Count; j++)
                {
                    if (user.FriendsFrom[j].friendFrom == allUsers[i])
                    {
                        allUsers.RemoveAt(i);
                    }
                }
            }
            foreach (var item in allUsers)
            {
                if (item != user)
                {
                    validUsers.Add(item);
                }
            }
            SearchPageViewModel model = new SearchPageViewModel()
            {
                Friends = user.FriendsFrom,
                Users = validUsers
            };
            return View(model);
        }

        public IActionResult Search(string userInputName)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            var allUsers = _userManager.Users.ToListAsync().Result;
            user.FriendsFrom = dbContext.FriendsRequest.Where(m => m.friendToId == user.Id).ToList();
            List<ApplicationUser> validUsers = new List<ApplicationUser>();
            if (userInputName != null)
            {
                // var users = await dbContext.Users.ToListAsync();
                foreach (var item in allUsers)
                {
                    string validName = "";
                    var name = item.firstName.ToArray();
                    for (int i = 0; i < userInputName.Length; i++)
                    {
                        validName += name[i];
                    }
                    if (validName == userInputName && item != user)
                    {
                        validUsers.Add(item);
                    }
                }
                for (int i = 0; i < allUsers.Count; i++)
                {
                    for (int j = 0; j < user.FriendsFrom.Count; j++)
                    {
                        if (user.FriendsFrom[j].friendFrom == allUsers[i])
                        {
                            allUsers.RemoveAt(i);
                        }
                    }
                }
                SearchPageViewModel model1 = new SearchPageViewModel()
                {
                    Friends = user.FriendsFrom,
                    Users = validUsers
                };
                return View("Index", model1);
            }
            for (int i = 0; i < allUsers.Count; i++)
            {
                for (int j = 0; j < user.FriendsFrom.Count; j++)
                {
                    if (user.FriendsFrom[j].friendFrom == allUsers[i])
                    {
                        allUsers.RemoveAt(i);
                    }
                }
            }
            foreach (var item in allUsers)
            {
                if (item != user)
                {
                    validUsers.Add(item);
                }
            }
            SearchPageViewModel model = new SearchPageViewModel()
            {
                Friends = user.FriendsFrom,
                Users = validUsers
            };
            return View("Index",model);
        }
        public async Task<IActionResult> AddFriend(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser userTo = _userManager.FindByIdAsync(id).Result;
            FriendRequest friendRequest = new FriendRequest()
            {
                friendFrom = user,
                friendTo = userTo,
                RequestTime = DateTime.Now,
                isConfirmed = false
            };
            dbContext.FriendsRequest.Add(friendRequest);
            dbContext.SaveChanges();
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            return LocalRedirect("~/Search"); ;
        }
        public async Task<IActionResult> Accept(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser friendUser = _userManager.FindByIdAsync(id).Result;
            Friends newFriend = new Friends()
            {
                friendUser = friendUser,
                friendUserId = id,
                user = user,
                userId = userId,
            };

            Friends newFriendTo = new Friends()
            {
                friendUser = user,
                friendUserId = userId,
                user = friendUser,
                userId = id,
            };
            foreach (var item in dbContext.FriendsRequest)
            {
                if (item.friendFromId == id)
                {
                    dbContext.FriendsRequest.Remove(item);
                }
            }
            dbContext.Friends.Add(newFriend);
            dbContext.Friends.Add(newFriendTo);
            dbContext.SaveChanges();
            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            return LocalRedirect("~/Search"); ;
        }
        public IActionResult Decline(string id)
        {
            foreach (var item in dbContext.FriendsRequest)
            {
                if (item.friendFromId == id)
                {
                    dbContext.FriendsRequest.Remove(item);
                    dbContext.SaveChanges();
                }
            }
            return View();
        }
        public IActionResult UserViewPage(string id)
        {
            ApplicationUser user = _userManager.FindByIdAsync(id).Result;
            List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();
            user.UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == user.Id).ToList();
            foreach (var item in friends)
            {
                ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                item.friendUser = friendUser;
            }
            FriendsViewModel model = new FriendsViewModel()
            {
                Friends = friends,
                User = user
            };
            return View(model);
        }
        // GET: SearchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SearchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SearchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SearchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SearchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SearchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
