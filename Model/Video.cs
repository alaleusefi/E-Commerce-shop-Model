using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Video : Product, IShippable
    {
        public bool IsPhysical { get; set; }
    }
}
