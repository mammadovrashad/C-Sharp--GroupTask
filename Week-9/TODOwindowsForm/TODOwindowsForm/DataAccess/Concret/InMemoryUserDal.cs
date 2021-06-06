using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOwindowsForm.Entities.Concret;

namespace TODOwindowsForm.DataAccess.Concret
{
    public class InMemoryUserDal : Abstract.IUserDal
    {


        #region filds
        private static readonly List<UserEntity> userEntities;
        #endregion

        #region ctor
        static InMemoryUserDal()
        {
            userEntities = new List<UserEntity>()
            {
                new UserEntity{Id=Guid.NewGuid(),Username="User1",Password="12345"}
            };
        }
        #endregion
        public void Add(UserEntity data)
        {
            userEntities.Add(data);
        }

        public List<UserEntity> GetAll()
        {
            return userEntities;
        }
    } 
    public class InMemoryTodoDal : Abstract.TodoDal
    {
    }

}
