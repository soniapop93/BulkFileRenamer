using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    if (!String.IsNullOrEmpty(fileName))
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
    }
}
