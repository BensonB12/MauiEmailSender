using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public class Utilities
    {
        public static string FindFile(string fileName)
        {
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (true)
            {
                var testPath = Path.Combine(directory.FullName, fileName);
                if (File.Exists(testPath))
                {
                    return testPath;
                }
                if (directory.FullName == directory.Root.FullName)
                {
                    throw new FileNotFoundException($"I looked for {fileName} in every folder from {Directory.GetCurrentDirectory()} to {directory.Root.FullName} and couldn't find it.");
                }
                directory = directory.Parent;
            }
        }
    }
}
