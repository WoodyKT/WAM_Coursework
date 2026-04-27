using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using WAM_Coursework.Conferences;
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
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };
            using (var reader = new StreamReader(GetDir(file)))
            using (var csv = new CsvReader(reader, config))
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

        public static int CreateNewId<T>(StorageFile file) where T : HasId
        {
            Random rnd = new Random();
            var existing = ReadRecords<T>(file).Select(r => r.Id).ToHashSet();

            int newId;
            do 
            { 
                newId = rnd.Next(1, int.MaxValue); 
            }
            while (existing.Contains(newId));

            return newId;
        }

        public static void UpdateRecord<T>(T updatedRecord, StorageFile file) where T : HasId
        {
            var existing = ReadRecords<T>(file);

            int index = existing.FindIndex(r => r.Id == updatedRecord.Id);
            if (index == -1) return;

            existing[index] = updatedRecord;

            using (var writer = new StreamWriter(GetDir(file), append: false))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(existing);
            }
        }
    }
}
