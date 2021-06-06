using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm.Bussiness.Abstract
{
   public interface ITodoServices
    {
        int Count();
        int Add(Entities.Concret.TodoEntity data);
        List<Entities.Concret.TodoEntity> GetAll();
       
    }
    public interface IUserSetvices
    {
    }
}
