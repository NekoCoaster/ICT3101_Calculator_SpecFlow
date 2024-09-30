namespace ICT3101_Calculator
{
    public class FileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
