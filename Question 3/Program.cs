using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class program
    {
        public static int size, index;
        public static int[] arr;



        static void Main()
        {
            Console.WriteLine("Enter the number  of elements in the array");
            try
            {

                size = Int32.Parse(Console.ReadLine());
                arr = new int[size];
                Console.WriteLine("Enter the elements");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter the index of the array element you want to access");
                index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The array element is " + arr[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad Format" );
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }

            Console.Read();
        }

    }
}
