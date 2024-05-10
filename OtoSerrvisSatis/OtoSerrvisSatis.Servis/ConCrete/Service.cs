using OtoSerrvisSatis.Servis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoSerrvisSatis.Servis.ConCrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {
        }

        public void Save(T entity)
        {
            
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }



    public interface IEntity
    {
    }

    public class Repository<T> where T : class, IEntity, new()
    {
        public Repository(DatabaseContext context)
        {
            Context = context;
        }

        public DatabaseContext Context { get; }
    }
}
