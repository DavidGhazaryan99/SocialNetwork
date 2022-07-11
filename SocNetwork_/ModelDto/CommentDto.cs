using System;

namespace SocNetwork_.ModelDto
{
    public class CommentDto
    {
        public string CommentigUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public string UserId { get; set; }
        public DateTime DataTime { get; set; }
        public string Comment { get; set; }
    }
}
