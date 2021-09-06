﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeAB.Reponsitories.Entities
{
    public class Comment
    {
        public string Key { get; set; }
        public string UserLocal { get; set; }
        public string DisplayName { get; set; }
        public string PhotoUrl { get; set; }
        public string Message { get; set; }
        public DateTime When { get; set; } = DateTime.Now;
        public string ReplyComment { get; set; } = "";
    }
}
