using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SocNetwork_.Data;
using SocNetwork_.Models;
using SocNetwork_.Service;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ServiceLogic _serviceLogic;

        public SearchController(ServiceLogic serviceLogic, ILogger<SearchController> logger, UserManager<ApplicationUser> userManager)
        {
            _serviceLogic = serviceLogic;
            _userManager = userManager;
            _logger = logger;
        }

        // GET: SearchController
        public async Task<ActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            var model = await _serviceLogic.SearchIndex(user);
            return View(model);
        }

        public async Task<IActionResult> Search(string userInputName)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            SearchPageViewModel model = await _serviceLogic.SearchUser(user, userInputName);
            return View("Index", model);
        }

        public async Task<IActionResult> AddFriend(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser userTo = _userManager.FindByIdAsync(id).Result;
            await _serviceLogic.SearchUserAddFriend(user, userTo);
            return LocalRedirect("~/Search"); ;
        }

        public async Task<IActionResult> Accept(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser friendUser = _userManager.FindByIdAsync(id).Result;
            await _serviceLogic.AcceptFreindRequest(friendUser, user, id, userId);
            return LocalRedirect("~/Search"); ;
        }

        public async Task<IActionResult> Decline(string id)
        {
            await _serviceLogic.DeclineFreindRequest(id);
            return View();
        }

        public async Task<IActionResult> UserViewPage(string id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            ApplicationUser userView = _userManager.FindByIdAsync(id).Result;
            var model = await _serviceLogic.UserView(userView, user, id);
            return View(model);
        }

        // GET: SearchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public JsonResult GetSearchingData(string SearchBy, string SearchValue)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            if (SearchBy == "ID")
            {
                try
                {
                    string id = SearchValue;
                    users = _userManager.Users.Where(x => x.Id == id || SearchValue == null).ToList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("(0) is not A ID", SearchValue);
                }
                return Json(users, new Newtonsoft.Json.JsonSerializerSettings());
            }
            else
            {
                users = _userManager.Users.Where(x => x.firstName.Contains(SearchValue) || SearchValue == null).ToList();
                return Json(users, new Newtonsoft.Json.JsonSerializerSettings());
            }
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
