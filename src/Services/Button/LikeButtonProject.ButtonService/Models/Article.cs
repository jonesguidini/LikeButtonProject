using LikeButtonProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Models
{
    public class Article : Entity, IAggregateRoot
    {
        public string Title { get; private set; }
        public string ArticleContent { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? LastLikeAction { get; private set; }
        public int LikesCount { get; private set; }


        public Article(string title, string articleContent)
        {
            Id = Guid.NewGuid();
            Title = title;
            ArticleContent = articleContent;
            CreatedAt = DateTime.Now;
        }

        public void UpdateLikesCount()
        {
            LikesCount += 1;
        }


    }
}
