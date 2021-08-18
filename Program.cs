using System;
using System.Linq;

namespace eyas
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int[arrayNumber];
            for (int i = arrayNumber; i>0; i--)
            {
                myArray[arrayNumber - i] = i;
            }
            foreach (int n in myArray)
            {
                Console.Write(myArray[n-1]);
            }

            Console.ReadKey();
        }
    }
}
