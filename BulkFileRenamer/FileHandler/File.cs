namespace BulkFileRenamer.FileHandler
{
    public class File
    {
        public string oldFileName { get; set; }
        public string oldFileExtension { get; set; }

        public string newFileName { get; set; }
        public string newFileExtension { get; set; }

        public File(string oldFileName, string oldFileExtension, string newFileName, string newFileExtension)
        {
            this.oldFileName = oldFileName;
            this.oldFileExtension = oldFileExtension;
            this.newFileName = newFileName;
            this.newFileExtension = newFileExtension;
        }
    }
}
