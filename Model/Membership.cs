﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Membership : Product
    {
        public MembershipType Type { get; set; }
    }
}
