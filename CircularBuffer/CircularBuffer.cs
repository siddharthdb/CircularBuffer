﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer
{
    public class CircularBuffer
    {
        private object[] _buffer;
        private int _start;
        private int _end;
        
        public CircularBuffer() : this (capacity: 10)
        {

        }

        public CircularBuffer(int capacity)
        {
            _buffer = new object[capacity + 1];
            _start = 0;
            _end = 0;
        }

        public void Write(double value)
        {
            _buffer[_end] = value;
            _end = (_end + 1) % _buffer.Length;

            if (_end == _start)
            {
                _start = (_start + 1) % _buffer.Length;
            }
        }
    }
}
