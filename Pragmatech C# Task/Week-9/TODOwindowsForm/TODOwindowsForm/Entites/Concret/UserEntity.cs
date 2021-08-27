﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
   public class UserEntity:BaseEntity<Guid>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public  class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int ImportanceLevel { get; set; }
        public Status Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
