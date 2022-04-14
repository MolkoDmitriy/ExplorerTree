﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorerTree.Models
{
    public static class ListFindIndex
    {
        public static int FindIndex<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int i = 0;
            foreach (var item in source)
            {
                if (predicate(item))
                    return i;
                i++;
            }
            return -1;
        }
        
    }
}
