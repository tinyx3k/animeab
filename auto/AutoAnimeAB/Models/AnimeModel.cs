﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAnimeAB.Models
{
    public class AnimeModel
    {
        public string Key { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; } = "";
        public int Views { get; set; }
        public string Link { get; set; }
        public int Episode { get; set; }
        public bool Iframe { get; set; }
    }
}
