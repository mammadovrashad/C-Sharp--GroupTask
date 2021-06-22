using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
    public class InMemoryUserDAL : IUserDAL
    {
        #region Filds
        private static readonly List<UserEntity> userEntitiesList;
        #endregion

        #region Ctor

        static InMemoryUserDAL()
        {
            userEntitiesList = new List<UserEntity>()
            {
                new UserEntity
                {
                    Id=Guid.NewGuid(),
                    Username="Rashad",
                    Password="1234"
                }
            };
        }
        #endregion
        public void Add(UserEntity data)
        {
            userEntitiesList.Add(data);
        }

        public List<UserEntity> GetAll()
        {
            return userEntitiesList;
        }
    }
    public class InMemoryTodoDAL : ITodoDAL
    {
        #region Filds
        private static readonly List<TodoEntity> TodoEntitiesList;
        #endregion

        #region Ctor

        static InMemoryTodoDAL()
        {
            TodoEntitiesList = new List<TodoEntity>();
           
        }

        public int Add(TodoEntity data)
        {
           TodoEntitiesList.Add(data);
            return 1;
        }
        #endregion
        public int Count()
        {
            
            return TodoEntitiesList.Count;
        }
    }
}
