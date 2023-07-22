using System;

namespace Resistor_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the number of bands of your resistor:");
            int numBands = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the colors of your resistor on diferent lines:");
            Console.WriteLine("(0)Black\n(1)Brown\n(2)Red\n(3)Orange\n(4)Yellow / Gold\n(5)Green\n(6)Blue\n(7)Violet\n(8)Grey / Silver\n(9)White");

            int[] colors = new int[numBands];

            // Assign values to the array
            for (int i = 0; i < numBands; i++)
            {
                int color = Convert.ToInt32(Console.ReadLine());
                colors[i] = color;
            }

            if (numBands == 4)
            {
                // Value in ohms
                float value = Convert.ToInt32(Convert.ToString(colors[0]) + Convert.ToString(colors[1])) * MathF.Pow(10, colors[2]);

                float tolerance = colors[3] == 1 ? 1 : (colors[3] == 2 ? 2 : (colors[3] == 4 ? 5 : 10));

                if (value % 1000 == 0)
                {
                    Console.WriteLine(value / 1000 + "kΩ ±" + tolerance + "%");
                }
                else
                {
                    Console.WriteLine(value + "Ω ±" + tolerance + "%");
                }
            }
            else if (numBands == 5)
            {
                // Value in ohms
                float value = Convert.ToInt32(Convert.ToString(colors[0]) + Convert.ToString(colors[1]) + Convert.ToString(colors[2])) * MathF.Pow(10, colors[3]);
                float tolerance = colors[4] == 1 ? 1 : (colors[4] == 2 ? 2 : (colors[4] == 4 ? 5 : 10));
                if (value % 1000 == 0)
                {
                    Console.WriteLine(value / 1000 + "kΩ ±" + tolerance + "%");
                }
                else
                {
                    Console.WriteLine(value + "Ω ±" + tolerance + "%");
                }
            }
        }
    }
}
