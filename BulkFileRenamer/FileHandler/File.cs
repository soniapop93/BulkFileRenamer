namespace BulkFileRenamer.FileHandler
{
    public class File
    {
        public string fileName { get; set; }
        public string fileExtension { get; set; }
        public string newFileName { get; set; }
        public string newFileExtension { get; set; }

        public File(string fileName, string fileExtension)
        {
            this.fileName = fileName;
            this.fileExtension = fileExtension;
        }
    }
}
