using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdmin.Entitites;

namespace UserAdmin.Abstract
{
    public interface IUserInterfeys<T> where T : BaseEntity, new()
    {
        void ADD(T entity);

        T GetByID(int id);

        void Update(T entity);
        List<T>GetAll();
        void Delete(int id);
    }
}
