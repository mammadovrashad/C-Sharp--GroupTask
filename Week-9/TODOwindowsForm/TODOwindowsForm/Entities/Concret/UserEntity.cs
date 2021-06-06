using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm.Entities.Concret
{
    public class UserEntity : Abstract.BaseEntity<Guid>
    {
       public string Username { get; set; }
       public string Password { get; set; }
    }
    public class TodoEntity : Abstract.BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int ImportanceLevel{ get; set; }
        public Enums.Status Status{ get; set; }
        public DateTime CreateDate { get; set; }
    }


}
