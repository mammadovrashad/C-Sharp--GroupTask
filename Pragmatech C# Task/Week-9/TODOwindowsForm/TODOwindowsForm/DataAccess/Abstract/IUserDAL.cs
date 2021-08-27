using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
    public interface IUserDAL
    {
        List<UserEntity> GetAll();
        void Add(UserEntity data);
    }
    public interface ITodoDAL
    {
        int Count();
        int Add(TodoEntity data);
    }
}
