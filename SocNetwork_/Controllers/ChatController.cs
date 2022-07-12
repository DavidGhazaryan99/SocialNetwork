using Microsoft.AspNetCore.Authorization;
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
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ServiceLogic _serviceLogic;
        public ChatController(ServiceLogic serviceLogic,ILogger<ChatController> logger, UserManager<ApplicationUser> userManager)
        {
            _serviceLogic = serviceLogic;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;

            if (User.Identity.IsAuthenticated)
                ViewBag.CurrentUserName = user.firstName + " " + user.lastName;

            ChatViewModel model = await _serviceLogic.ChatView(user);
            return View(model);
        }

        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(HttpContext.User);
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                message.UserID = user.Id;
                message.UserName = User.Identity.Name;
                message.User = user;
                await _serviceLogic.CreateMessage(message);
                return Ok();
            }
            return Error();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
