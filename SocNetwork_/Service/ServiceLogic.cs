using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using SocNetwork_.Controllers;
using SocNetwork_.Data;
using SocNetwork_.ModelDto;
using SocNetwork_.Models;
using SocNetwork_.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Service
{
    public class ServiceLogic
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public ServiceLogic(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
            dbContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<PostViewModel> GetPosts(ApplicationUser user, string userId)
        {
            try
            {
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
                return post;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task CreatePost(string textForPost, IFormFile postFile, ApplicationUser user)
        {
            try
            {
                UserPictures userPictures = new UserPictures()
                {
                    textForPicture = textForPost,
                    Picture = UploadedFile(postFile),
                    ApplicationUser = user,
                    dateTimePost = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss"))
                };
                await dbContext.UserPictures.AddAsync(userPictures);
                await dbContext.SaveChangesAsync();
                await _userManager.UpdateAsync(user);
                await _signInManager.RefreshSignInAsync(user);
            }
            catch (Exception)
            {
                throw;
            }
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

        public async Task<List<UserPictures>> GetPhotos(string userId)
        {
            try
            {
                var UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == userId).ToList();
                foreach (var item in UserPictures)
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
                UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == userId).ToList();
                return UserPictures;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<UserPictures> AddLike(string userId, int id)
        {
            try
            {
                bool liked = false;
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
                return post;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<CommentDto> AddComment(string userId, int id, string comment)
        {
            try
            {
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
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
                CommentDto commentDto = new CommentDto()
                {
                    CommentigUserId = userId,
                    FirstName = user.firstName,
                    LastName = user.lastName,
                    ProfilePicture = user.ProfilePicture,
                    UserId = user.Id,
                    DataTime = Convert.ToDateTime(DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss")),
                    Comment = comment
                };
                return commentDto;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<ChatViewModel> ChatView(string userId, ApplicationUser user)
        {
            try
            {
                List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();

                foreach (var item in friends)
                {
                    ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                    item.friendUser = friendUser;
                }
                List<Message> all = dbContext.Messages.ToList();
                var messages = dbContext.Messages.Where(
                    m => (m.UserID == user.Id &&
                    m.ReceiverId == friends.First().friendUser.Id) ||
                    (m.UserID == friends.First().friendUser.Id &&
                    m.ReceiverId == user.Id)
                    ).ToList();

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
                return model;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task CreateMessage(Message message)
        {
            try
            {
                await dbContext.Messages.AddAsync(message);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<FriendsViewModel> GetFriends(ApplicationUser user)
        {
            try
            {
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
                    ThisIsFriend = true
                };
                return model;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<FriendsViewModel> SearchFriend(ApplicationUser user, string userInputName)
        {
            try
            {
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
                            break;
                        }
                    }
                    FriendsViewModel model = new FriendsViewModel()
                    {
                        UserView = user,
                        UserViewFriends = friends,
                        ThisIsFriend = true
                    };
                    return model;
                }
                FriendsViewModel NullModel = new FriendsViewModel()
                {
                    UserView = user,
                    ThisIsFriend = true
                };
                return NullModel;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task DeleteFriend(ApplicationUser user, string userId, ApplicationUser friendUser, string deleteFriendUserId)
        {
            try
            {
                Friends deleteFriendUserDB = new Friends()
                {
                    user = user,
                    userId = userId,
                    friendUser = friendUser,
                    friendUserId = deleteFriendUserId
                };
                Friends deleteFriend_FriendUserDB = new Friends()
                {
                    user = friendUser,
                    userId = deleteFriendUserId,
                    friendUser = user,
                    friendUserId = userId
                };
                foreach (var item in dbContext.Friends)
                {
                    if (item.userId == deleteFriendUserDB.userId && item.friendUserId == deleteFriendUserDB.friendUserId)
                    {
                        dbContext.Friends.Remove(item);
                    }
                    if (item.userId == deleteFriend_FriendUserDB.userId && item.friendUserId == deleteFriend_FriendUserDB.friendUserId)
                    {
                        dbContext.Friends.Remove(item);
                    }
                }
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }
        public async Task<SearchPageViewModel> SearchIndex(ApplicationUser user)
        {
            try
            {
                var allUsers = _userManager.Users.ToList();
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
                return model;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<SearchPageViewModel> SearchUser(ApplicationUser user,string userInputName)
        {
            try
            {
                var allUsers = _userManager.Users.ToList();
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
                    return model1;
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
                return model;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task SearchUserAddFriend(ApplicationUser user, ApplicationUser userTo)
        {
            try
            {
                FriendRequest friendRequest = new FriendRequest()
                {
                    friendFrom = user,
                    friendTo = userTo,
                    RequestTime = DateTime.Now,
                    isConfirmed = false
                };
                await dbContext.FriendsRequest.AddAsync(friendRequest);
                await dbContext.SaveChangesAsync();
                await _userManager.UpdateAsync(user);
                await _signInManager.RefreshSignInAsync(user);
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task AcceptFreindRequest(ApplicationUser friendUser, ApplicationUser user,string friendUserId,string userId)
        {
            try
            {
                Friends newFriend = new Friends()
                {
                    friendUser = friendUser,
                    friendUserId = friendUserId,
                    user = user,
                    userId = userId,
                };

                Friends newFriendTo = new Friends()
                {
                    friendUser = user,
                    friendUserId = userId,
                    user = friendUser,
                    userId = friendUserId,
                };
                foreach (var item in dbContext.FriendsRequest)
                {
                    if (item.friendFromId == friendUserId)
                    {
                        dbContext.FriendsRequest.Remove(item);
                    }
                }
                await dbContext.Friends.AddAsync(newFriend);
                await dbContext.Friends.AddAsync(newFriendTo);
                await dbContext.SaveChangesAsync();
                await _userManager.UpdateAsync(user);
                await _signInManager.RefreshSignInAsync(user);
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task DeclineFreindRequest(string id)
        {
            try
            {
                foreach (var item in dbContext.FriendsRequest)
                {
                    if (item.friendFromId == id)
                    {
                        dbContext.FriendsRequest.Remove(item);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }

        public async Task<FriendsViewModel> UserView(ApplicationUser userView,ApplicationUser user,string userViewId)
        {
            try
            {
                bool thisIsFriend = false;
                string friendRequest = null;
                List<Friends> userVirwFriends = dbContext.Friends.Where(m => m.userId == userView.Id).ToList();
                userView.UserPictures = dbContext.UserPictures.Where(m => m.ApplicationUserId == userView.Id).ToList();
                foreach (var item in userVirwFriends)
                {
                    ApplicationUser friendUser = _userManager.FindByIdAsync(item.friendUserId).Result;
                    item.friendUser = friendUser;
                }
                foreach (var item in userView.UserPictures)
                {
                    item.LikedUsers = dbContext.LikedUsers.Where(m => m.UserPictureId == item.id).ToList();
                    item.CommentingUsers = dbContext.CommentingUsers.Where(m => m.UserPictureId == item.id).ToList();
                    item.CommentingUsers = item.CommentingUsers.OrderBy(s => s.DateTime).ToList();
                }

                List<Friends> friends = dbContext.Friends.Where(m => m.userId == user.Id).ToList();
                foreach (var item in friends)
                {
                    if (item.friendUserId == userViewId)
                    {
                        thisIsFriend = true;
                    };
                };

                List<FriendRequest> friendRequest1 = dbContext.FriendsRequest.Where(m => m.friendFromId == userView.Id).ToList();
                foreach (var item in friendRequest1)
                {
                    if (item.friendToId == user.Id)
                    {
                        friendRequest = "true";
                    }
                }
                List<FriendRequest> friendRequest2 = dbContext.FriendsRequest.Where(m => m.friendToId == userView.Id).ToList();
                foreach (var item in friendRequest2)
                {
                    if (item.friendFromId == user.Id)
                    {
                        friendRequest = "false";
                    }
                }
                FriendsViewModel model = new FriendsViewModel()
                {
                    UserViewFriends = userVirwFriends,
                    UserView = userView,
                    SignInUser = user,
                    ThisIsFriend = thisIsFriend,
                    FriendRequest = friendRequest
                };
                return model;
            }
            catch (Exception)
            {
                await dbContext.SaveChangesAsync();
                throw;
            }
        }
    }
}
