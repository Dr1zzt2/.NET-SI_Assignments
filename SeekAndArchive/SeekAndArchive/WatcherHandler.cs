using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class WatcherHandler
    {
        private static List<FileSystemWatcher> _watchers = new List<FileSystemWatcher>();
        public static void AddWatcher(List<FileInfo> files) {
            foreach (FileInfo file in files)
            {
                FileSystemWatcher newWatcher = new FileSystemWatcher(file.DirectoryName, file.Name);

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                newWatcher.NotifyFilter =  NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName
                                         | NotifyFilters.DirectoryName;

                // Add event handlers.
                newWatcher.Changed += OnChanged;
                newWatcher.Created += OnChanged;
                newWatcher.Deleted += OnChanged;
                newWatcher.Renamed += OnRenamed;

                // Begin watching.
                newWatcher.EnableRaisingEvents = true;
                _watchers.Add(newWatcher);

                Console.WriteLine($"{file.FullName} is under surveillance.");

                // Wait for the user to quit the program.
                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }
        }
        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e) =>
            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");

        private static void OnRenamed(object source, RenamedEventArgs e) =>
            // Specify what is done when a file is renamed.
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
    }
}
