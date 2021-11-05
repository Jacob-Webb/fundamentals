using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILinkedListNode<T>
    {
        ILinkedListNode<T> Next { get; set; }
        T Value { get; set; }
    }
}