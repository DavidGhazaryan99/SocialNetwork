using Microsoft.AspNetCore.Http;
using SocNetwork_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.ViewModels
{
    public class PostViewModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string profilePicture { get; set; }
        public List<UserPictures> post { get; set; }
    }
}
