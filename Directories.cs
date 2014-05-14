using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DriveSpace
{
    public class Directories
    {
        // vars


        // getters, setters
        public string Path { get; set; }
        public string Drive { get; set; }
        public double Space { get; set; }
        public double Full { get; set; }

        public Directories()
        {

        }

        public Directories(string path)
        {

        }

        public Directories(string path, double space)
        {

        }

        public Directories(string path, string drive, double space, double full)
        {

        }



       

        public double GetDirectorySize(string directory)
        {
            double size = 0;
            foreach (string dir in Directory.GetDirectories(directory))
            {
                GetDirectorySize(dir);
            }

            foreach (FileInfo file in new DirectoryInfo(directory).GetFiles())
            {
                size += file.Length;
            }

            return size;
        }
    }
}
