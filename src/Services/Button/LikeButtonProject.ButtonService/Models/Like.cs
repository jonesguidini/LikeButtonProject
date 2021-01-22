using LikeButtonProject.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonProject.ButtonService.Models
{
    public class Like : Entity
    {
        //public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public string UserIP { get; set; }

    }
}
