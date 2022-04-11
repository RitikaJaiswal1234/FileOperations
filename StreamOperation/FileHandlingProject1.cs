using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamOperation
{
    public class FileHandlingProject1
    {
        public static void Main(String[] args)
        {
            const string workingDirectory = "C:\\Users\\Ritika Jaiswal\\Desktop\\RJ";
            SubDirectories subDirectories = new SubDirectories();
            subDirectories.getSubDirectories(workingDirectory);
        }
    }
}

