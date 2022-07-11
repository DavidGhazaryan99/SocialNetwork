using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.Models;
using SocNetwork_.Service;
using SocNetwork_.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Controllers
{
    public class FriendController : Controller
    {
        private readonly ILogger<FriendController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ServiceLogic _serviceLogic;

        public FriendController(ServiceLogic serviceLogic, ILogger<FriendController> logger, UserManager<ApplicationUser> userManager)
        {
            _serviceLogic = serviceLogic;
            _userManager = userManager;
            _logger = logger;
        }
        // GET: FriendController
        public async Task<ActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            FriendsViewModel model = await _serviceLogic.GetFriends(user);
            return View(model);
        }

        public async Task<IActionResult> Search(string userInputName)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            FriendsViewModel model = await _serviceLogic.SearchFriend(user, userInputName);
            return View("Index", model);
        }

        public async Task<ActionResult> DeleteFriend(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser friendUser = _userManager.FindByIdAsync(id).Result;
            await _serviceLogic.DeleteFriend(user, userId, friendUser, id);
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
