using Newtonsoft.Json;

class program
{
    static void Main(string[] args)
    {
        WriteWeatherToCsv(ReadFromFile(), "weather.csv");
    }

    static List<Weather> ReadFromFile()
    {
        List<Weather> list = new List<Weather>();
        var folderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString() + Path.DirectorySeparatorChar + "Files";
        foreach (var file in Directory.GetFiles(folderPath))
        {
            string fileString = File.ReadAllText(file);
            list.Add(JsonConvert.DeserializeObject<Weather>(fileString));
        }

        return list;
    }

    static void WriteWeatherToCsv(List<Weather> stats, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var stat in stats) writer.WriteLine($"{stat}");
        }
    }
}
