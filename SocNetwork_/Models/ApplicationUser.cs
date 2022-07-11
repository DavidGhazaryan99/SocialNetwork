using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get;set; }
        [Required(ErrorMessage = "Please choose profile image")]
        [Column(TypeName = "varchar(MAX)")]
        public string ProfilePicture { get; set; }
        public List<UserPictures> UserPictures { get; set; }
        public List<FriendRequest> FriendsFrom { get; set; }
        public List<FriendRequest> FriendsTo { get; set; }

    }
}
