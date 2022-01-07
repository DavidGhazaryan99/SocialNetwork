using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.ViewModels
{
    public class FriendsViewModel
    {
        public List<Friends> Friends { get; set; }
        public ApplicationUser User { get; set; }
    }
}
