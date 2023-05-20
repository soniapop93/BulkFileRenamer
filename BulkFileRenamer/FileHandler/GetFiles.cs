namespace BulkFileRenamer.FileHandler
{
    public class GetFiles
    {
        public string[] getFilesFromFolder(string folderPath, string fileExtension)
        {
            string[] files = Directory.GetFiles(folderPath, fileExtension);

            return files;
        }

        public void getFileExtensionsAvailableInFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);

            for(int i = 0; i < files.Length; i++)
            {
               
            }
        }
    }
}
