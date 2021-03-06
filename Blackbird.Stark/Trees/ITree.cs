﻿using System;

namespace Blackbird.Stark.Trees
{
    public interface ITree<in K, V> where K:IComparable<K>
    {
        void Add(K key, V value);

        V Get(K key);

        bool Remove(K key);

        void Clear();

        int Count { get; }

        bool ContainsKey(K key);
    }
}
