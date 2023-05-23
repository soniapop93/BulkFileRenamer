namespace BulkFileRenamer.FileHandler
{
    public class RenameFiles
    {
        public void bulkRenameFiles(string[] files, string newPath, string fileNewName, string fileExtension)
        {
            int index = 1;

            for (int i = 0;i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]); 

                if (file.Exists)
                {
                    string fileName = nameFile(fileNewName, fileExtension.Replace(".", ""), index.ToString());

                    bool pathExists = folderExists(newPath);

                    if (!String.IsNullOrEmpty(fileName) && pathExists)
                    {
                        file.MoveTo(newPath + "\\" + fileName);
                    }
                }
                index++;
            }
        }

        private string nameFile(string fileNewName, string fileExtension, string fileNumber)
        {
            string fileName = "";

            if (fileNewName != null && fileExtension != null)
            {
                if (String.IsNullOrEmpty(fileNewName))
                {
                    fileName = fileNumber + "." + fileExtension;
                }
                else
                {
                    fileName = fileNewName + "_" + fileNumber + "." + fileExtension;
                }
            }
            return fileName;
        }

        private bool folderExists(string newPath)
        {
            bool exists = Directory.Exists(newPath);

            if (!exists)
            {
                Directory.CreateDirectory(newPath);
                exists = true;
            }
            return exists;
        }
    }
}
