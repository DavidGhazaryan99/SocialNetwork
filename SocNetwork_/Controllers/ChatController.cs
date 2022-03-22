using Microsoft.AspNetCore.Authorization;
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
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger<ChatController> _logger;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public ChatController(ILogger<ChatController> logger, IHttpContextAccessor httpContextAccessor, ApplicationDbContext _context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
            dbContext = _context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: ChatController
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
            List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();
            if (User.Identity.IsAuthenticated)
                ViewBag.CurrentUserName = user.firstName + " " + user.lastName;

            foreach (var item in friends)
            {
                ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                item.friendUser = friendUser;
            }
            var all = await dbContext.Messages.ToListAsync();
            var messages = await dbContext.Messages.Where(
                m =>( m.UserID == user.Id &&
                m.ReceiverId == friends.First().friendUser.Id )||
                (m.UserID == friends.First().friendUser.Id &&
                m.ReceiverId == user.Id)
                ).ToListAsync();

            foreach (var item in messages)
            {
                ApplicationUser messageUser = _userManager.FindByIdAsync(item.UserID).Result;
                item.User = messageUser;
            }


            ChatViewModel model = new ChatViewModel()
            {
                UserViewFriends = friends,
                UserView = friends.First().friendUser,
                ThisIsFriend = true,
                SignInUser = user,
                Messages = messages
            };
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
                await dbContext.Messages.AddAsync(message);
                await dbContext.SaveChangesAsync();
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
