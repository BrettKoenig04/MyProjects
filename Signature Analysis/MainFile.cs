using System;
using System.IO;
using System.Linq;

namespace Signature_Analysis
{
    public class MainFile
    {
        public static void Main(string[] args)
        {
            // Gather main directory and CSV file path
            string fileDirectory = checkFileDirectory();
            string selection = getSelection();
            string csvFile;

            if (selection == "1")
            {
                csvFile = createCSVFile();
            }
            else
            {
                csvFile = checkCSVFile();
            }
            
            // Calls function which loops through each file in main directory and subdirectories if permitted
            ProcessingDirectory processDirectory = new ProcessingDirectory();
            processDirectory.ProcessDirectory(fileDirectory, csvFile);
        }


        public static string checkFileDirectory() // Check if main directory exists
        {
            Console.Write("Please enter desired directory: ");
            string fileDirectory = Console.ReadLine().Trim();

            while (Directory.Exists(fileDirectory) == false)
            {
                Console.Write("Directory does not exist. Please enter another directory: ");
                fileDirectory = Console.ReadLine().Trim();
            }
            Console.WriteLine("Directory has been selected.\n");
            return fileDirectory;
        }


        public static string getSelection() // Checks whether to create new or use existing CSV file
        {
            string selection;
            do
            {
                Console.WriteLine("Please enter the number of the option you'd like to choose.\n1. Create new CSV file\n2. Use pre-existing CSV file");
                selection = Console.ReadLine().Trim();
                if ((selection == "1") || (selection == "2"))
                    break;
            } while (true);
            return selection;
        }


        public static string createCSVFile() // Check if directory exists before file creation
        {
            Console.Write("Please enter desired directory to create CSV file: ");
            string fileDirectory = Console.ReadLine().Trim();

            while (Directory.Exists(fileDirectory) == false)
            {
                Console.Write("Directory does not exist. Please enter another directory: ");
                fileDirectory = Console.ReadLine().Trim();
            }
            Console.WriteLine("Directory has been selected.\n");

            string fileName;
            do // Asks for user for desired filename which only includes letters or digits
            {
                Console.WriteLine("Please enter a new filename only using letters and numbers");
                fileName = Console.ReadLine().Trim();
                if (fileName.All(Char.IsLetterOrDigit) && fileName != "" && File.Exists(fileDirectory + @"\" + fileName + ".csv") == false)
                {
                    using (FileStream fs = File.Create(fileDirectory + "/" + fileName + ".csv"))
                    {
                        fileDirectory = fileDirectory + @"\" + fileName + ".csv";
                    }
                    break;
                }
            } while (true);

            return fileDirectory;
        }


        public static string checkCSVFile() // Check if CSV file path exists
        {
            Console.Write("Please enter CSV file location: ");
            string csvFile = Console.ReadLine().Trim();

            while (File.Exists(csvFile) == false)
            {
                Console.Write("File not found. Please enter another file location: ");
                csvFile = Console.ReadLine().Trim();
            }
            Console.WriteLine("File has been selected.\n");
            return csvFile;
        }
    }
}