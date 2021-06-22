﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOwindowsForm
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
    public abstract class BaseEntity
    {

    }
    public abstract class BaseEntity<T> : BaseEntity, IEntity<T>
    {
        public T Id { get; set;}
    }

}
