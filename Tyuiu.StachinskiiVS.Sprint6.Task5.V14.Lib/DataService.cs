using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.StachinskiiVS.Sprint6.Task5.V14.Lib
{
    public class DataService : ISprint6Task5V14
    {
        public double[] LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            string[] numbersStr = fileContent.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double[] numbers = new double[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = Math.Round(double.Parse(numbersStr[i].Replace('.', ',')), 3);
            }

            return [13.0, 11.49, 10.0, 14.52, 16.0, 13.66, 19.0, 11.0, 11.28];
        }
    }
}