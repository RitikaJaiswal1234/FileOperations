using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FileHandling;

namespace StreamOperation
{
    public class SubDirectories
    {
        public void getSubDirectories(String workingDirectory)
        {
            Queue directoryQueue = new Queue();
            directoryQueue.Enqueue(workingDirectory);
            while (directoryQueue.Count > 0)
            {
                string currentDirectory = directoryQueue.Dequeue().ToString();
                Console.WriteLine(currentDirectory);
                FileDescription fileDescription = new FileDescription();
                fileDescription.getFileDescription(currentDirectory);
                string[] subDirectories = Directory.GetDirectories(currentDirectory);

                if (subDirectories.Length > 0)
                    foreach (string subDirectory in subDirectories)
                    {
                        directoryQueue.Enqueue(subDirectory);
                    }
                else
                    continue;
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
    }
}

