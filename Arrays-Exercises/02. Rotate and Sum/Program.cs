using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RotateАndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());
            int[] sum = new int[array1.Length];

            for (int k = 0; k < rotateTimes; k++)
            {
                int[] rotate = new int[array1.Length];

                
                for (int i = 0; i < array1.Length; i++)
                {
                    if (i == 0)
                    {
                        rotate[0] = array1[rotate.Length - 1];
                    }
                    else
                    {
                        rotate[i] = array1[i - 1];
                    }
                    sum[i] += rotate[i];
                }
                array1 = rotate;
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
