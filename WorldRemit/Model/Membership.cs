﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Model
{
    public class Membership : Product
    {
        public MembershipType Type { get; set; }
    }
}
