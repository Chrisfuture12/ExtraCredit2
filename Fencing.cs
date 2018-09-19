using System;

namespace extraCredit2
{
    class Fencing
    {
        static void Main(){
            double yardSize;
            double length;
            double height;
            string value1;
            string value2;
            Console.WriteLine("Provide the length of the square-shaped yard in feet: ");
            value1 = Console.ReadLine();
            length = double.Parse(value1);
            Console.ReadKey();
            Console.WriteLine("Provide the height of the square-shaped yard in feet: ");
            value2 = Console.ReadLine();
            height = double.Parse(value2);
            Console.ReadKey();
            yardSize = length*height;
            Console.WriteLine("You will need " + yardSize + " Square feet of fencing for the required perimeter of the yard.");

            Console.WriteLine("This fencing calculator was brought to you by Chris Morris.");
        }
    }
}