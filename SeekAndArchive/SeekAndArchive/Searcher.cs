using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Searcher
    {
        private List<FileInfo> files = new List<FileInfo>();

        public List<FileInfo> Search(DirectoryInfo currentDirectory, string searchedName)
        {
            foreach (FileInfo file in currentDirectory.GetFiles())
            {
                if (file.Name.Contains(searchedName))
                    files.Add(file);
            }
            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                Search(dir, searchedName);
            }
            return files;
        }
    }
}
