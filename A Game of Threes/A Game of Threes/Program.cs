using System;

namespace A_Game_of_Threes
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 321231241;

            int[] moveOptions = { 0, -1, 1 };

            while (value != 1)
            {
                Console.WriteLine(value.ToString() + " " + moveOptions[value % 3].ToString());
                value = (value + moveOptions[value % 3]) / 3;
            }
            Console.WriteLine("1");
            Console.ReadKey();
        }
    }
}
