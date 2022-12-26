﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _0_Framework.Domain
{
   public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }

        public EntityBase()
        {
            CreationDate = DateTime.Now;
            
        }
    }
}
