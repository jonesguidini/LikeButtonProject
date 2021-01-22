using LikeButtonProject.Core.DomainObjects;
using System;
namespace LikeButtonProject.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
