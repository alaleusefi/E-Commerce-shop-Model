using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public interface IShippable
    {
        bool IsPhysical { get; set; }
    }
}
