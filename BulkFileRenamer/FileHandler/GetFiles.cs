namespace BulkFileRenamer.FileHandler
{
    public class GetFiles
    {
        public string[] getFilesFromFolder(string folderPath, string fileExtension)
        {
            string[] files = Directory.GetFiles(folderPath, fileExtension);

            return files;
        }

        public List<string> getFileExtensionsAvailableInFolder(string folderPath)
        {
            List<string> extensions = new List<string>;

            string[] files = Directory.GetFiles(folderPath);

            for(int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                string fileExtension = file.Extension;

                if (!extensions.Contains(fileExtension))
                {
                    extensions.Add(fileExtension);
                }
            }
            return extensions;
        }
    }
}
