﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_1_2.Interfaces;

namespace Task2_1_2.Figures.Polygonals
{
    class Triangle : Figure, ISquareable
    {
        Point vertice1;

        Point vertice2;

        Point vertice3;

        public Triangle(Point vertice1, Point vertice2, Point vertice3)
        {
            Vertice1 = vertice1;
            Vertice2 = vertice2;
            Vertice3 = vertice3;
        }

        public override string Name => "Triangle";

        public Point Vertice1
        {
            get => vertice1;
            set => vertice1 = value;
        }

        public Point Vertice2
        {
            get => vertice2;
            set => vertice2 = value;
        }

        public Point Vertice3
        {
            get => vertice3;
            set => vertice3 = value;
        }

        public double Side1
        {
            get => Vertice1 - Vertice2;
        }

        public double Side2
        {
            get => Vertice1 - Vertice3;
        }

        public double Side3
        {
            get => Vertice2 - Vertice3;
        }

        public override string ToString()
        {
            return $"{Name} a = {Side1}, b = {Side2}, c = {Side3}, A: {Vertice1}, B: {Vertice2}, C: {Vertice3}, with square = {GetSquare()}";
        }

        public override int Color 
        { 
            get;
            set; 
        }

        public override void Display()
        {
            Console.WriteLine(ToString());
        }

        public override void Move(Point moveOn)
        {
            Vertice1.Move(moveOn);
            Vertice2.Move(moveOn);
            Vertice3.Move(moveOn);
        }

        public double GetSquare()
        {
            double P = Side1 + Side2 + Side3;
            double p = P / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
