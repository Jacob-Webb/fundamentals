using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShallowCloneable
    {
        object ShallowClone();
    }

    public interface IShallowCloneable<T> : IShallowCloneable 
    {
      T ShallowClone();
    }
}