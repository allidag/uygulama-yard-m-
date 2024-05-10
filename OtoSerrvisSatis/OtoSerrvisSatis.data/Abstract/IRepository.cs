using System.Linq.Expressions;

namespace OtoSerrvisSatis.data.Abstract
{
    public interface IRepository <T> where T : class
    {
        List<T> GetAll ();

        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void Add(T entity);     
        void Delete(T entity);
        void Update(T entity);
        int save();
        Task<T> FindAsync (int İd);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<T> GetAllAsync();

        Task<T> GetAllAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);
        Task<int> SaveAsync ();

    }
}
