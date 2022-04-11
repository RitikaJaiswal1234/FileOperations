using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class FileDescription
    {
        public void getFileDescription(string currentDirectory) 
        {
            string[] filePath = Directory.GetFiles(currentDirectory);
            if (filePath.Length > 0)
            {
                Dictionary<string,List<string>> fileDescriptions = new Dictionary<string, List<string>>();
                foreach (string str in filePath)
                {
                    if(fileDescriptions.ContainsKey(Path.GetExtension(str)))
                    {
                        fileDescriptions[Path.GetExtension(str)].Add(str);
                    }
                    else
                    {
                        fileDescriptions[Path.GetExtension(str)] = new List<string>();
                        fileDescriptions[Path.GetExtension(str)].Add(str);
                    }
                }
                foreach (string fileExtention in fileDescriptions.Keys)
                {
                    var fileList = fileDescriptions[fileExtention];
                    Console.WriteLine($"FieType : {fileExtention}");
                    foreach (var file in fileList)
                    {
                        Console.WriteLine($"File Name : {Path.GetFileName(file)},File Size : {Path.GetFileName(file).Length}kb");
                    }
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
            }
        }
    }
}
