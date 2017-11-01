﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WOM3.Models
{
    public class OnlineFriends
    {
        public string Username { get; set; }

        public string Avatar { get; set; }
        public bool isOnline { get; set; }
        public bool isInGame { get; set; }
        public int NumOfNotSeen { get; set; }
        public ChatMessage Message { get; set; }

   
    }
}