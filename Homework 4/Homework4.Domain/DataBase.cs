
using Homework4.Domain.Models;
using Newtonsoft.Json;

namespace Homework4.Domain
{
    public class DataBase <T> where T : Dog
    {
        private string _folderPath { get; set; }
        private string _filePath { get; set; }

        public DataBase()
        {
            _folderPath = @"..\..\..\DataBase";
            _filePath = @"..\..\..\DataBase\Dogs.json";

            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }

            List<T> data = ReadFromJson();
            if(data == null)
            {
                WriteToJson (new List<T>());
            }
        }

        private List<T> ReadFromJson()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd();

                    return JsonConvert.DeserializeObject<List<T>>(data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private void WriteToJson(List<T> data)
        {
            string convertedData = JsonConvert.SerializeObject(data);

            try
            {
                using(StreamWriter sw = new StreamWriter(_filePath))
                { 
                    sw.WriteLine(convertedData); 
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintAll()
        {
            List<T> data =  ReadFromJson();
            foreach (T item in data)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Color:{item.Color}");
            }
            
        }

        public void insertItem(T item)
        {
            List<T> data = ReadFromJson();
            data.Add(item);
            WriteToJson(data);
        }
    }
}
