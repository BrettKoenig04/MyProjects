using System;
using System.IO;

namespace Signature_Analysis
{
    public class ProcessingDirectory
    {
        public void ProcessDirectory(string directory, string csvFile)
        {
            // Ask user whether to include subdirectories
            string includeSubDirectory;
            do
            {
                Console.Write("Would you like to include subdirectories in your search? Yes or No?: ");
                includeSubDirectory = Console.ReadLine().ToLower().Trim();
                if ((includeSubDirectory == "yes") || (includeSubDirectory == "no"))
                    break;
            } while (true);

            if (includeSubDirectory == "yes")
            {
                foreach (string path in Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories))
                {
                    ProcessFile(path, csvFile);
                }
            }
            else
            {
                foreach (string path in Directory.EnumerateFiles(directory, "*", SearchOption.TopDirectoryOnly))
                {
                    ProcessFile(path, csvFile);
                }
            }
            Console.Write("Data saved sucessfully saved to CSV file.");
        }


        public void ProcessFile(string path, string csvFile)
        {
            // Analyze files and use stringbuilder to fill in CSV file
            AnalyzeFile analyze = new AnalyzeFile();
            string fileSignature = analyze.GetFileSignature(path);  //Getting the file signature (method in AnalyzeFile.cs)
            string fileType = analyze.GetFileType(fileSignature); // Getting the file type using the fileSignature (method in AnalyzeFile.cs)
            string hash = analyze.GetMD5Hash(path);  //Getting the MD5 hash of the file contents (method in AnalyzeFile.cs)
            analyze.CsvFill(path, fileType, hash, csvFile);  //CsvFill - fullPath, fileExtension, hash, and the csvFile are the parameters (method in AnalyzeFile.cs)
        }
    }
}