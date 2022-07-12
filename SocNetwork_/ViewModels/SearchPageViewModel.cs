using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.ViewModels
{
    public class SearchPageViewModel
    {
        public List<FriendRequest> FriendsRequest { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public List<Friends> UserFriends { get; set; }

    }
}
