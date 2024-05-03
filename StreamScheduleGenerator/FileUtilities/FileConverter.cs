namespace StreamScheduleGenerator.FileUtilities
{
    public class FileConverter
    {
        public static string FileToBase64(string fileName)
        {
            using (Image image = Image.FromFile(fileName))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    string base64String = Convert.ToBase64String(imageBytes);
                    return "data:" + MimeTypes.DetermineFileTypeByExtension(fileName) + ";base64," + base64String;
                }
            }
        }
    }
}
