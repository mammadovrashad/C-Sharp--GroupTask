using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
    public class TodoService : ITodoServices
    {
        #region Filds
        private readonly InMemoryTodoDAL _todoDAL;
        #endregion

        #region Ctor
        public TodoService(InMemoryTodoDAL todoDAL)
        {
            _todoDAL = todoDAL;
        }
        #endregion
        public int Add(TodoEntity data)
        {

            return _todoDAL.Add(data); ;
        }

        public int Cout()
        {
            return _todoDAL.Count();
        }

        public List<TodoEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
