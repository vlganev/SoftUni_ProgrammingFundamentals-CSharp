using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousCache
{
    class Program
    {
        static void Main()
        {
            List<DataSet> datasetsList = new List<DataSet>();
            List<string> notFoundData = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }
                if (input.Contains("->") || input.Contains('|'))
                {
                    char[] delimiters = { '-', '|' };
                    string[] tokens = input.Split(delimiters);
                    string dataKey = tokens[0].Trim();
                    int dataSize = int.Parse(tokens[1].Trim('>').Trim());
                    string dataSet = tokens[2].Trim();
                    if (datasetsList.Any(c => c.dataSet == dataSet))
                    {
                        DataSet existingDataSet = datasetsList.First(d => d.dataSet == dataSet);
                        existingDataSet.dataSizeSum += dataSize;
                        existingDataSet.dataKeysList.Add(dataKey);
                    }
                    else
                    {
                        notFoundData.Add(input);
                    }
                }
                else
                {
                    string dataSet = input;
                    DataSet dataset = new DataSet { dataSet = dataSet, dataSizeSum = 0, dataKeysList = new List<string>() };
                    datasetsList.Add(dataset);
                }
                
            }
            for (int i = 0; i < notFoundData.Count; i++)
            {
                char[] delimiters = { '-', '|' };
                string[] tokens = notFoundData[i].Split(delimiters);
                string dataKey = tokens[0].Trim();
                int dataSize = int.Parse(tokens[1].Trim('>').Trim());
                string dataSet = tokens[2].Trim();
                if (datasetsList.Any(c => c.dataSet == dataSet))
                {
                    DataSet existingDataSet = datasetsList.First(d => d.dataSet == dataSet);
                    existingDataSet.dataSizeSum += dataSize;
                    existingDataSet.dataKeysList.Add(dataKey);
                }
            }
            
            if (datasetsList.Count != 0)
            {
                int count = 0;
                foreach (var item in datasetsList.OrderByDescending(x => x.dataSizeSum))
                {
                    if (count == 1)
                    {
                        break;
                    }
                    Console.WriteLine($"Data Set: {item.dataSet}, Total Size: {item.dataSizeSum}");
                    for (int i = 0; i < item.dataKeysList.Count; i++)
                    {
                        Console.WriteLine($"$.{item.dataKeysList[i]}");
                    }
                    count++;
                }
            }
        }
    }
    class DataSet
    {
        public List<string> dataKeysList { get; set; }
        public decimal dataSizeSum { get; set; }
        public string dataSet { get; set; }
    }
}
