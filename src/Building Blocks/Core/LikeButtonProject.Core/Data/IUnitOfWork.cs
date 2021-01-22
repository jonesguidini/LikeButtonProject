using System.Threading.Tasks;

namespace LikeButtonProject.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
