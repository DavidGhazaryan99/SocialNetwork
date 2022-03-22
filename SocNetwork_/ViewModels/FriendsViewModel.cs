using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.ViewModels
{
    public class FriendsViewModel
    {
        public List<Friends> UserViewFriends { get; set; }
        public ApplicationUser UserView { get; set; }
        public ApplicationUser SignInUser { get; set; }
        public bool ThisIsFriend { get; set; }
        public string FriendRequest { get; set; }
    }
}
