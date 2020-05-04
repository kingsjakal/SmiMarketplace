﻿using System.Collections.Generic;
using Smi.Core;

namespace Smi.Tests
{
    public class BaseEntityEqualityComparer<T> : IEqualityComparer<T> where T : BaseEntity
    {
        public bool Equals(T x, T y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode(T obj)
        {
            return obj.Id;
        }
    }
}