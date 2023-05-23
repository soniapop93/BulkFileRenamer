using BulkFileRenamer.FileHandler;
using BulkFileRenamer.User;

public class Program
{
    public static void Main(string[] args)
    {
        /*
           =============================================================
           =============================================================
            Bulk File Renamer

            [X] Takes input path from user where the files are stored
            [X] Checks the extensions available in the path and displays them
            [X] Asks user which extension file wants to rename
            [X] Takes input path from user where the files wants to be moved
            [X] If the added path doesn't exist, will create it
            
           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");

        UserInput userInput = new UserInput();
        GetFiles getFiles = new GetFiles();
        RenameFiles renameFiles = new RenameFiles();

        Console.WriteLine("Please insert the path from where do you want to rename all the files: ");
        string pathInput = userInput.getUserInput();

        if (!String.IsNullOrEmpty(pathInput))
        {

            List<string> fileExtensionsAvailable = getFiles.getFileExtensionsAvailableInFolder(pathInput);

            if (fileExtensionsAvailable.Count > 0)
            {
                Console.WriteLine("Available extensions in the folder: \n {0}", String.Join("\n" ,fileExtensionsAvailable));
            }
            else
            {
                Console.WriteLine("There are no files available in folder!");
            }

            Console.WriteLine("Please add the file extension of the files you want to rename: ");
            string fileExtensionInput = userInput.getUserInput();

            if(!String.IsNullOrEmpty(fileExtensionInput))
            {
                if (fileExtensionsAvailable.Contains(fileExtensionInput))
                {
                    string[] files = getFiles.getFilesFromFolder(pathInput, "*" + fileExtensionInput);

                    if (files.Length > 0)
                    {
                        Console.WriteLine("Please add the new path where you want to save the files renamed: ");
                        string newPath = userInput.getUserInput();

                        if (!String.IsNullOrEmpty(newPath))
                        {
                            Console.WriteLine("Please add the new name of the files: ");
                            string newFileName = userInput.getUserInput();

                            renameFiles.bulkRenameFiles(files, newPath, newFileName, fileExtensionInput);
                        }
                        else
                        {
                            Console.WriteLine("The path added is not correct");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("You didn't add an extension that is available in the folder");
                }
            }
            else
            {
                Console.WriteLine("Extension you've added is null or empty");
            }
        }
        else
        {
            Console.WriteLine("Path you've added is null or empty");
        }

        Console.WriteLine("------------------------ SCRIPT FINISHED ------------------------");
    }
}