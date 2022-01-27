using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class LikedUsers
    {
        public int id { get; set; }
        public DateTime DateTime { get; set; }
        public string LikedUserId { get; set; }
        public ApplicationUser LikedUser { get; set; }
        public int UserPictureId { get; set; }
        public string ApplicationUserId { get; set; }
        public UserPictures UserPictures { get; set; }
    }
}
