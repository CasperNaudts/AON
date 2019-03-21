using System;
using System.Collections.Generic;
using System.Text;

namespace SuperChat.Domain
{
    public class Chat
    {

        public IList<User> UserIds { get; set; } = new List<User>();
        public IList<Message> Messages { get; set; } = new List<Message>();

    }
}
