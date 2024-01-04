﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool Haschanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid { get {  return true; } } // here just returning true
       
    }
}
