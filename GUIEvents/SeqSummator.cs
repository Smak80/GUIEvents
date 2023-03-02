﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEvents
{
    public class SeqSummator
    {
        private int _maxVal;

        public long? Result
        {
            get;
            set;
        }

        public SeqSummator(int maxVal)
        {
            _maxVal = maxVal;
        }

        public void Sum()
        {
            var s = 0L;
            for (int i = 1; i <= _maxVal; i++)
            {
                s += i;
            }

            Result = s;
        }
    }
}
