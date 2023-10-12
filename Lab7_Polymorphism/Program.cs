using System.Drawing;
using System;

namespace Lab7_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // I create an instance of every class, apart from the abstract class Geometri
            // all of the sides and radiuses happen to be = 4 by default
            Console.WriteLine($"Area Fyrkant: {(new Fyrkant()).Area():0.##}");
            Console.WriteLine($"Area Rektangel: {(new Rektangel()).Area():0.##}");
            Console.WriteLine($"Area Parallellogram: {(new Parallellogram()).Area():0.##}");
            Console.WriteLine($"Area Ellips: {(new Ellips()).Area():0.##}");
            Console.WriteLine($"Area Cirkel: {(new Cirkel()).Area():0.##}");

            // all of the sides and radiuses can be reassigned in the constructor
            Console.WriteLine(" ------- med egna mått ------- ");
            Console.WriteLine($"Area Fyrkant: {(new Fyrkant(2,2,2)).Area():0.##}");
            Console.WriteLine($"Area Rektangel: {(new Rektangel(3,4)).Area():0.##}");
            Console.WriteLine($"Area Parallellogram: {(new Parallellogram(5,6)).Area():0.##}");
            Console.WriteLine($"Area Ellips: {(new Ellips(3,9)).Area():0.##}");
            Console.WriteLine($"Area Cirkel: {(new Cirkel(3)).Area():0.##}");

        }
    }
}