using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocNetwork_.Models
{
    public class Conversation
    {
        public Conversation()
        {
            status = messageStatus.Sent;
        }

        public enum messageStatus
        {
            Sent,
            Delivered
        }

        public int id { get; set; }
        public string sender_id { get; set; }
        public string receiver_id { get; set; }
        public string userIdentityName { get; set; }
        public string message { get; set; }
        public messageStatus status { get; set; }
        public DateTime When { get; set; }
    }
}
