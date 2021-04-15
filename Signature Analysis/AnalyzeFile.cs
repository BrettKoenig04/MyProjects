using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Signature_Analysis
{
    public class AnalyzeFile
    {
        // Check sequence of bytes to get file signature
        public string GetFileSignature(string path)
        {
            int byteCount = 4;
            byte[] buffer;
            using (var filesStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var  binaryReader = new BinaryReader(filesStream))
                {
                    buffer = binaryReader.ReadBytes(byteCount);
                }
            }
            var hex = BitConverter.ToString(buffer);
            return hex.Replace("-", "").ToLower();
        }


        // Return specific string based on file signature
        public string GetFileType(string fileSignature)
        {
            if (fileSignature == "ffd8ffe0" || fileSignature == "ffd8ffe1" || fileSignature == "ffd8ffe2" || fileSignature == "ffd8ffe8")
            {
                return "File type: JPG";
            }
            else if (fileSignature == "25504446")
            {
                return "File type: PDF";
            }
            else
            {
                return "Misc";
            }
        }


        // loops through the array’s bytes and uses ToString to convert each byte into a two-digit hexadecimal value
        public string GetMD5Hash(string path)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    byte[] checksum = md5.ComputeHash(stream);
                    for (int i = 0; i < checksum.Length; i++)
                    {
                        stringBuilder.Append(checksum[i].ToString("x2"));
                    }
                    return stringBuilder.ToString();
                }
            }
        }


        // Uses StringBuilder to create a list of JPG/PDF data for our CSV file
        public void CsvFill(string fullPath, string fileType, string hash, string csvFile)
        {
            string[][] fileInformation = new string[][]{new string[]{fullPath, fileType, hash}};
            int length = fileInformation.GetLength(0);
            StringBuilder stringBuilder = new StringBuilder();

            if (fileType != "Misc")
            {
                for (int i = 0; i < length; i++)
                {
                    stringBuilder.AppendLine(string.Join(",", fileInformation[i]));
                }
            }
            File.AppendAllText(csvFile, stringBuilder.ToString());
        }
    }
}