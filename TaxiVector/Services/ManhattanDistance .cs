using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DeHaro.CabbieGeometry.Logic
{
    class ManhattanDistance : IDistanceMeassurement
    {
        private Point _p1;
        private Point _p2;
        public ManhattanDistance(Point p1, Point p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        private int GetPrivatePropety(Point p, string PropName)
        {
            Type typ = typeof(Point);
            FieldInfo type = typ.GetField(PropName, BindingFlags.NonPublic | BindingFlags.Instance);
            var value = type.GetValue(p);

            return (int)value;
        }
        public int Calculate()
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            x1 = GetPrivatePropety(_p1, "_x");
            x2 = GetPrivatePropety(_p2, "_x");
            y1 = GetPrivatePropety(_p1, "_y");
            y2 = GetPrivatePropety(_p2, "_y");

            int FinalX, FinalY;

            FinalX = x1 - x2;
            FinalX = System.Math.Abs(FinalX);
            FinalY = y1 - y2;
            FinalY = System.Math.Abs(FinalY);

            return FinalX + FinalY;
        }
    }
}
