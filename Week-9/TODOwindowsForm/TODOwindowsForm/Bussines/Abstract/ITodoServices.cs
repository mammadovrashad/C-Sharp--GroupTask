using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
    public interface ITodoServices
    {
        int Cout();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
    }
    public interface IUserServices
    {
    }
}
