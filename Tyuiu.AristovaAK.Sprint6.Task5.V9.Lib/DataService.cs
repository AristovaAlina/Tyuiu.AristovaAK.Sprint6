using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AristovaAK.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            // Первый проход: подсчет всех строк
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            // Второй проход: чтение всех чисел
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            // Фильтрация: оставляем только нули и округляем
            numsArray = numsArray
                .Where(val => Math.Abs(val) < 0.000001) // сравнение для double
                .Select(val => Math.Round(val, 3))      // округление до 3 знаков
                .ToArray();

            return numsArray;
        }
    }
}