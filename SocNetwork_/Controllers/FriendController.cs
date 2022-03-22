using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.Models;
using SocNetwork_.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SocNetwork_.Controllers
{
    public class FriendController : Controller
    {
        private readonly ILogger<FriendController> _logger;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public FriendController(ILogger<FriendController> logger, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }
        // GET: FriendController
        public ActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();
            foreach (var item in friends)
            {
                ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                item.friendUser = friendUser;
            }
            FriendsViewModel model = new FriendsViewModel()
            {
                UserViewFriends = friends,
                UserView = user,
                ThisIsFriend=true
            };
            return View(model);
        }

        public IActionResult Search(string userInputName)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();
            foreach (var item in friends)
            {
                ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                item.friendUser = friendUser;
            }
            if (userInputName != null)
            {
                foreach (var item in friends)
                {
                    string validName = "";
                    var name = item.friendUser.firstName.ToArray();
                    for (int i = 0; i < userInputName.Length; i++)
                    {
                        validName += name[i];
                    }
                    if (validName != userInputName)
                    {
                        friends.Remove(item);
                    }
                    if (friends.Count == 0)
                    {
                        FriendsViewModel model = new FriendsViewModel()
                        {
                            UserView = user,
                            ThisIsFriend=true
                        };
                        return View("Index", model);
                    }
                }
                FriendsViewModel model1 = new FriendsViewModel()
                {
                    UserView = user,
                    UserViewFriends = friends,
                    ThisIsFriend=true
                };
                return View("Index", model1);
            }
            FriendsViewModel model2 = new FriendsViewModel()
            {
                UserView = user,
                UserViewFriends = friends,
                ThisIsFriend=true
            };
            return View("Index", model2);
        }

        public ActionResult DeleteFriend(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser friendUser = _userManager.FindByIdAsync(id).Result;
            Friends deleteFriend = new Friends()
            {
                user = user,
                userId = userId,
                friendUser = friendUser,
                friendUserId = id
            };
            Friends deleteFriend2 = new Friends()
            {
                user = friendUser,
                userId = id,
                friendUser = user,
                friendUserId = userId
            };
            foreach (var item in dbContext.Friends)
            {
                if (item.userId == deleteFriend.userId && item.friendUserId == deleteFriend.friendUserId)
                {
                    dbContext.Friends.Remove(item);
                }
                if (item.userId == deleteFriend2.userId && item.friendUserId == deleteFriend2.friendUserId)
                {
                    dbContext.Friends.Remove(item);
                }
            }
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: FriendController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FriendController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FriendController/Create
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

        // GET: FriendController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FriendController/Edit/5
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

        // GET: FriendController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FriendController/Delete/5
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
