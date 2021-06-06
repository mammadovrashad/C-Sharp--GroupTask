using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm.DataAccess.Abstract
{
   public interface IUserDal
    {

        List<Entities.Concret.UserEntity> GetAll();
        void Add(Entities.Concret.UserEntity data);
    }

    public interface TodoDal
    {
    }
}
