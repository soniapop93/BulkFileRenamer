using BulkFileRenamer.FileHandler;
using BulkFileRenamer.User;

public class Program
{
    public static void Main(string[] args)
    {
        /*
           =============================================================
           =============================================================
            
           =============================================================
           =============================================================
        */

        Console.WriteLine("------------------------ SCRIPT STARTED ------------------------");

        UserInput userInput = new UserInput();
        GetFiles getFiles = new GetFiles();

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
                    //TODO: implement logic 
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