﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAnimeAB.Models
{
   public class Table
    {
        public const string COLLECTION = "Collections";
        public const string ANIME = "Anime";
        public const string ANIMEDETAIL = "AnimeDetail";
        public const string CATEGORIES = "Categories";
        public const string USERS = "Users";
        public const string ANIMESERIES = "AnimeSeries";
        public const string ANIMESERIESDETAIL = "AnimeSeriesDetail";

        public static string PATHANIMEDETAILED(string animeKey, string animeDetailKey)
        {
            return ANIME + "/" + animeKey + "/" + ANIMEDETAIL + "/" + animeDetailKey;
        }
    }
}
