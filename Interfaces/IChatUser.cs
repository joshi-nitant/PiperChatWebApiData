using PiperChatWebApiData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PiperChatWebApiData.Interfaces
{
    interface IChatUser
    {
      

        public List<ChatUser> GetChatUsers();
        public ChatUser GetChatUser(int chatUserId);
        public ChatUser AddChatUser(ChatUser chatUser);

    }
}
