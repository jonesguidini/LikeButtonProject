﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.MVC.Models
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLikeAction { get; set; }

        public int LikesCount { get; set; }
    }
}
