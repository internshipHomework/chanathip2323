using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "1", "2", "3", "4","5","6","7","8","9","A" };
            string[] array0 = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            int count = 1;
            while (count <= 12)
            {
                Console.WriteLine("Please choose LED to turn On/Off:");
                String f = Console.ReadLine();
                for (int i = 0; i < array.Length; i++){
                    if (array[i] == f & array0[i] == "[ ]"){
                        array0[i] = "[!]";
                    }
                    else if (array[i] == f & array0[i] == "[!]"){
                        array0[i] = "[ ]";
                    }

                }
                Console.WriteLine(String.Join(" ", array0));
                Console.WriteLine("1   2   3   4   5   6   7   8   9   A");
                count ++;
            }
        }
    }
}
