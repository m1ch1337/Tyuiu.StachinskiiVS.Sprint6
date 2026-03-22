using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.StachinskiiVS.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = Math.Sin(x) - 2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    result[i] = 0;
                }
                else
                {
                    double value = (5 * x + 2.5) / denominator + 2;
                    result[i] = Math.Round(value, 2);
                }
            }

            return result;
        }
    }
}