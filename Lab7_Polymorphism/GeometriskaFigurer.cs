using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Polymorphism
{
    // Rektangel and Parallellogram are special cases of a Fyrkant 
    // calculations are implemented in Fyrkant with Rektangel and Parallellogram inheriting them
    internal class Fyrkant : Geometri
    {
        public double ParallelSide1 {  get; set; }
        public double ParallelSide2 { get; set; }
        public double Height { get; set;}
        public Fyrkant(double parallelside1=4, double parallelside2 = 4, double height = 4)
        {
            ParallelSide1 = parallelside1;
            ParallelSide2 = parallelside2;
            Height = height;
        }

        public override double Area()
        {
            return (ParallelSide1 + ParallelSide2)/2*Height;
        }
    }

    internal class Rektangel : Fyrkant
    {
        public Rektangel(double width = 4, double height = 4) : base(width, width, height)
        {

        }
    }

    internal class Parallellogram : Fyrkant
    {
        public Parallellogram(double baseSide = 4, double height = 4) : base(baseSide, baseSide, height)
        {

        }
    }

    // Cirkel is a special case of an Ellips 
    // calculations are implemented in Ellips with Cirkel inheriting them
    internal class Ellips : Geometri
    {
        public double ShorterRadius { get; set; }
        public double LongerRadius { get; set; }
        public Ellips(double shorterRadius = 4, double longerRadius = 4)
        {
            ShorterRadius = shorterRadius;
            LongerRadius = longerRadius;
        }
        public override double Area()
        {
            return Math.PI * ShorterRadius * LongerRadius;
        }
    }
    internal class Cirkel : Ellips
    {
        public Cirkel(double radius = 4):base(radius,radius)
        {
            
        }
    }

}
