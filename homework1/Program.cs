using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomework1 Led = new ControlLed();
            Console.WriteLine(Led.DisplayLEDOnScreen(""));
            Console.ReadLine();
        }
    }
}
public interface IHomework1
{
    string DisplayLEDOnScreen(string ledNo);
}
public class ControlLed : IHomework1
{
    public string DisplayLEDOnScreen(string ledNo)
    {
        string[] array1 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        string[] array2 = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        int count = 1;
        while (count <= 100)
        {
            string DisplayLEDOnScreen;
            DisplayLEDOnScreen = ledNo;
            Console.WriteLine(String.Join(" ", array2));
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A ");
            count++;
            Console.WriteLine("Please choose LED to turn On/Off:");
            String LED = Console.ReadLine();
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == LED & array2[i] == "[ ]")
                {
                    array2[i] = "[!]";
                }
                else if (array1[i] == LED & array2[i] == "[!]")
                {
                    array2[i] = "[ ]";
                }
            }
        }
        {
            throw new NotImplementedException();
        }
    }
}
