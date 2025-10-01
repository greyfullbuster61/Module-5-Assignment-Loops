using System;

namespace Module5Assignment_Loops // module 5 assignment
{
    class Program
    {
        static void Main()  // main function
        {
            // ask user numbers
            Console.Write("Enter a start number: ");
            int startNumber = Convert.ToInt32(Console.ReadLine()); // convert input

            Console.Write("Enter an end number: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Start Number: " + startNumber);
            Console.WriteLine("End Number: " + endNumber);

            int counter = startNumber; // start counter

            // while loop to count from start to end
            while (counter <= endNumber)
            {
                Console.WriteLine("Counter: " + counter); // print counter
                counter = counter + 1; // add 1 each time
            }

            Console.WriteLine("done!"); // lowercase done like a beginner
            Console.WriteLine(""); // extra line for spacing maybe beginner would do
        }
    }
}
