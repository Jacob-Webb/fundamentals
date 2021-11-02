using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDeepCloneable
    {
        object DeepClone();
    }

    public interface IDeepCloneable<T> : IDeepCloneable
    {
      T DeepClone();
    }
}