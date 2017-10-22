using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = int.Parse(Console.ReadLine());
            long filterTimeInSeconds = int.Parse(Console.ReadLine());
            long filterFactor = int.Parse(Console.ReadLine());
            long uploadingTimeInSeconds = int.Parse(Console.ReadLine());

            long numberOfUsefulPictures = (int)Math.Ceiling(numberOfPictures * filterFactor / 100.0);
            long filterTimeTotal = filterTimeInSeconds * numberOfPictures;
            long uploadTime = numberOfUsefulPictures * uploadingTimeInSeconds;

            long totalTimeInSeconds = filterTimeTotal + uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSeconds);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
