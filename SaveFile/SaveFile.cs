namespace Rookies.Middlewares
{
    public static class SaveFile
    {
        public static void WriteToFileByStream(string directoryPath, string fileName, string textContent)
        {
            using (var fileStream = new FileStream(Path.Combine(directoryPath, fileName), FileMode.OpenOrCreate))
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(textContent);
                }
            }
        }
    }
}