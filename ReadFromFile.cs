namespace ConfigsLoaderMockUp
{
    public abstract class ReadFromFile
    {
        public abstract void UpdateConfig(string line);

        public abstract void Read(bool all = false);

        protected void ReadSingleFile(string path)
        {
            string? line;

            using var fs = File.OpenRead(path);
            using var reader = new StreamReader(fs);

            while ((line = reader.ReadLine()) != null)
            {
                UpdateConfig(line);
            }
        }
    }
}
