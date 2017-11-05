using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main()
        {
            decimal websiteNumber = decimal.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            decimal sumLosses = 0;
            List<string> allWebsites = new List<string>();
            for (int i = 0; i < websiteNumber; i++)
            {
                string[] websiteData = Console
                    .ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string siteName = websiteData[0];
                decimal siteVisits = decimal.Parse(websiteData[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websiteData[2]);

                decimal currentWebsiteLosses = siteVisits * siteCommercialPricePerVisit;
                allWebsites.Add(siteName);
                sumLosses += currentWebsiteLosses;
            }
            for (int i = 0; i < allWebsites.Count; i++)
            {
                Console.WriteLine(allWebsites[i]);
            }
            Console.WriteLine($"Total Loss: {sumLosses:f20}");
            BigInteger result = 1;
            int count = 0;
            while (true)
            {
                if (count == websiteNumber)
                {
                    break;
                }
                result *= securityKey;
                count++;
            }
            Console.WriteLine($"Security Token: {result}");
        }
    }
}
