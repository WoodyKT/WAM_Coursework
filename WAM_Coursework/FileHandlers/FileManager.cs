using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace WAM_Coursework.FileHandlers
{
    public sealed class FileManager
    {
        public static readonly FileManager Instance = new FileManager();

        public enum StorageFile
        {
            users,
            conferences
        };

        private static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),  "FairView", "ConferenceSystem");
       

        public static readonly IReadOnlyDictionary<StorageFile, string> Dirs =
         new Dictionary<StorageFile, string>
          {
              [StorageFile.users] = GetDir("Users"),
              [StorageFile.conferences] = GetDir("Conferences")
          };

        private static string GetDir(string file)
        {
            var path = Path.Combine(basePath, file);
            Directory.CreateDirectory(path);
            return path;
        }

        static FileManager()
        {
      
        }

        static string GetFromFile(string valueToSearch, StorageFile file)
        {
            StreamReader reader = new StreamReader(Dirs[file]);
            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            string result = csvReader.GetRecord(valueToSearch);

            return result;
        }

        static void WriteToFile(string valueToSave, StorageFile file)
        {
            StreamWriter writer = new StreamWriter(Dirs[file]);
            CsvWriter csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvwriter.WriteField(valueToSave, true);
        }

 
    }
}
