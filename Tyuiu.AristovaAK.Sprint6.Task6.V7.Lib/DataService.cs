using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AristovaAK.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string resSrt = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length >= 3)
                    {
                        resSrt += words[2] + " ";
                    }
                }
                return resSrt;
            }
        }
    }
}
