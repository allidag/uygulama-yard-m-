using OtoSerrvisSatis.Servis.ConCrete;

namespace OtoSerrvisSatis.Servis.Abstract
{
    public interface IService<T> : IRepository<T> where T : class, IEntity, new()
    {
        void Delete(OtoSerrvisSatis.Entities.Rol rol);
        Task<string?> GetAllAsync();
        void Save();
    }

    public interface IRepository<T> where T : class, IEntity, new()
    {

    }
}
