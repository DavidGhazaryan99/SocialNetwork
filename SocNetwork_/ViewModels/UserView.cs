using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.ViewModels
{
    public class UserView
    {
        public ApplicationUser user { get; set; }
        public ApplicationUser userView { get; set; }
        public List<Friends> Friends { get; set; }
        

    }
}
