using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using WAM_Coursework.Users;

namespace WAM_Coursework.FileHandlers
{
    public sealed class FileManager
    {
        FileManager()
        {
            CreateFileIfNotExists();
        }

        public enum StorageFile
        {
            users,
            conferences,
            talks,
            reviews
        };

        private static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FairView");

        public static readonly FileManager Instance = new FileManager();

        private static string GetDir(StorageFile file)
        {
            string fileName = file.ToString() + ".csv";
            var path = Path.Combine(basePath, fileName);
            Directory.CreateDirectory(basePath);
            return path;
        }

        #region Read/Write
        public static void WriteRecords<T>(IEnumerable<T> records, StorageFile file)
        {
            var existing = ReadRecords<T>(file);
            existing.AddRange(records);

            using (var writer = new StreamWriter(GetDir(file), append: false))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(existing);
            }
        }

        public static List<T> ReadRecords<T>(StorageFile file)
        {
            using (var reader = new StreamReader(GetDir(file)))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<T>().ToList();
            }
        }
        #endregion

        private void CreateFileIfNotExists()
        {          
            foreach (var file in Enum.GetValues(typeof(StorageFile)).Cast<StorageFile>())
            {
                if (!File.Exists(GetDir(file)))
                {
                    File.Create(GetDir(file));
                }
            }
        }
    }
}
