using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Automatic Properties *****\n");

            Car c = new AutoProps.Car();
            c.PetName = "Frank";
            c.Color = "Red";
            c.Speed = 55;

            Console.WriteLine("Your car is named {0}? Thats odd..", c.PetName);
            c.DisplayStats();
            Console.ReadLine();
        }
    }
}
