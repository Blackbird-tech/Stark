using System;

namespace Blackbird.Stark.Trees.Nodes
{
    internal class AvlNode<TK,TV>: BinaryNode<TK,TV> where TK:IComparable<TK>
    {
        private int _height;
        public int Height => _height;
        public int Balance => LeftHeight - RightHeight;
        private int LeftHeight => Left?._height ?? 0;
        private int RightHeight => Right?._height ?? 0;

        public new AvlNode<TK, TV> Left
        {
            get => base.Left as AvlNode<TK, TV>;
            set => base.Left = value;
        }

        public new AvlNode<TK, TV> Right
        {
            get => base.Right as AvlNode<TK, TV>;
            set => base.Right = value;
        }

        public new AvlNode<TK, TV> Parent
        {
            get => base.Parent as AvlNode<TK, TV>;
            set => base.Parent = value;
        }

        public int RefreshHeight()
        {
            _height = 1 + System.Math.Max(LeftHeight, RightHeight);
            return _height;
        }

        public AvlNode(TK key, TV val)
        {
            Key = key;
            Value = val;
            _height = 1;
        }
    }
}