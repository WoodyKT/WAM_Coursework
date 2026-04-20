using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

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
            conferences
        };

        private static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FairView");

        public static readonly FileManager Instance = new FileManager();

        private static string GetDir(StorageFile file)
        {
            string fileName = string.Empty;
            switch (file)
            {
                case StorageFile.users:
                    fileName = "users.csv";
                    break;
                case StorageFile.conferences:
                    fileName = "conferences.csv";
                    break;
                default:
                    break;
            }
            var path = Path.Combine(basePath, fileName);
            Directory.CreateDirectory(basePath);
            return path;
        }

        #region Read/Write
        public static void WriteRecords<T>(IEnumerable<T> records, StorageFile file)
        {
            using (var writer = new StreamWriter(GetDir(file), append: false))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
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
            if (!File.Exists(GetDir(StorageFile.users)))
                File.Create(GetDir(StorageFile.users));

            if (!File.Exists(GetDir(StorageFile.conferences)))
                File.Create(GetDir(StorageFile.conferences));
        }
    }
}
