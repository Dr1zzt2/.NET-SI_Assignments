using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedName = args[0];
            if (searchedName.Contains('.'))
            {
                string[] strings = searchedName.Split('.');
                searchedName = strings[0];
            }

            DirectoryInfo currentDirectory = new DirectoryInfo(args[1]);
            Searcher searcher = new Searcher();
            List<FileInfo> files = searcher.Search(currentDirectory, searchedName);
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.DirectoryName + "\\" + file.Name);
            }
            Console.ReadKey();
        }
    }
}
