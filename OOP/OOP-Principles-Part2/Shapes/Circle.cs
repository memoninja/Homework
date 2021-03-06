﻿using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) { }
        public override double CalculateSurface()
        {
            return this.Height * this.Width * Math.PI;
        }
    }
}
