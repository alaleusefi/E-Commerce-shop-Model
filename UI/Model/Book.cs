﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Model
{
    public class Book : Product, IShippable
    {
        public bool IsPhysical { get; set; }
    }
}