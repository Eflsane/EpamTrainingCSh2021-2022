﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1_2.Figures.Shapes
{
    abstract class Shape : Figure
    { 
        public abstract int Color 
        {
            get;
            set; 
        }

        public abstract double Size
        {
            get;
        }
    }
}
