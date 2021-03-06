﻿using System;

namespace Blackbird.Stark.Ranges
{
    public class Range
    {
        public long L { get; set; }
        public long R { get; set; }

        public long Length { get { return 1 + R - L; } }

        public bool IsOverlapping(Range r)
        {
            if (r.L <= R && r.L >= L)
                return true;
            if (r.R >= L && r.R <= R)
                return true;
            return false;
        }

        public Range Merge(Range overlapping)
        {
            var r = new Range
            {
                L = System.Math.Min(L, overlapping.L),
                R = System.Math.Max(R, overlapping.R)
            };
            return r;
        }
    }
}
