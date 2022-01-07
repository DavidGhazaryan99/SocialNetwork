using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class FriendRequest
    {
        public int id { get; set; }
        public bool isConfirmed { get; set; }
        public DateTime RequestTime { get; set; }
        public string friendFromId { get; set; }
        public string friendToId { get; set; }
        public ApplicationUser friendFrom { get; set; }
        public ApplicationUser friendTo { get; set; }

    }

}
