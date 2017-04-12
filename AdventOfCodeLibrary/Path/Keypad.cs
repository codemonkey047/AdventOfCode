﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeLibrary.Path
{
    class Keypad
    {
        private int[,] _keys;

        public Keypad(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.MaxValue = width * height;
            var value = 1;
            _keys = new int[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    _keys[i, j] = value++;
                }
            }
        }

        public int Width { get; }
        public int Height { get; }
        public int MaxValue { get; }

        public int getValue(Coordinate point)
        {
            if (point.X < 0 || point.Y < 0) return -1;
            if (point.X < Width && point.Y < Height)
            {
                return _keys[point.X,point.Y];
            }
            return -1;
        }
    }

   
}