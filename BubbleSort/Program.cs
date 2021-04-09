using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {3, 0, 2, 5, -1, 4, 1};
            int temp = 0;

            Console.WriteLine("Original Array: ");
            foreach (var item in myArray)
            {
                Console.Write(item + ", ");
            }

            for (int p = 0; p < myArray.Length -1; p++)
            {
                for (int i = 0; i < myArray.Length -1; i++)
                {
                    if (myArray[i] > myArray[i + 1])
                    {
                        temp = myArray[i + 1];
                        myArray[i + 1] = myArray[i];
                        myArray[i] = temp;
                    }
                }
            }

            Console.WriteLine("\n" + "Sorted Array: ");
            foreach (var item in myArray)
            {
                Console.Write(item + ", ");
                
            }

            Console.Write("\n");
            Console.WriteLine();
        }
    }
}
