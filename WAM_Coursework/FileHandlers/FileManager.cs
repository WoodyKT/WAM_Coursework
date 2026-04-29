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
    /// <summary>
    /// Handles interaction with the database CSV files storing all application records.
    /// </summary>
    public sealed class FileManager
    {
        /// <summary>
        /// FileManager class constructor. Immediately calls method to generate database files if one isn't present.
        /// </summary>
        FileManager()
        {
            CreateFileIfNotExists();
            CreateAdminIfNotExists();
        }

        /// <summary>
        /// An enumerator used to group all database files.
        /// </summary>
        public enum StorageFile
        {
            users,
            conferences,
            talks,
            reviews,
            selectedTalks
        };

        private static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FairView");

        public static readonly FileManager Instance = new FileManager();

        /// <summary>
        /// Returns the windows path to the passed in database files.
        /// </summary>
        /// <param name="file">Files to find path to.</param>
        /// <returns></returns>
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

        public static void ClearFile(StorageFile file)
        {
            using (var writer = new StreamWriter(GetDir(file), append: false))
            {
                writer.Write(string.Empty);
            }
        }
        #endregion
        /// <summary>
        /// Uses the StorageFile enum to check if each database file exists. 
        /// If any are missing, they are created.
        /// </summary>
        private void CreateFileIfNotExists()
        {
            foreach (var file in Enum.GetValues(typeof(StorageFile)).Cast<StorageFile>())
            {
                if (!File.Exists(GetDir(file)))
                {
                    File.Create(GetDir(file)).Close();
                }
            }
        }

        /// <summary>
        /// Generates a random new ID and checks for match in database. 
        /// If it already exists in database, keep generating new IDs until one is unique. 
        /// </summary>
        /// <typeparam name="T">type parameter of generic class HasId.</typeparam>
        /// <param name="file">the database file to be searched for matching record.</param>
        /// <returns>The newly generated ID.</returns>
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

        /// <summary>
        /// Overwrites a record in the database with a 
        /// new version of that record which is passed in.
        /// </summary>
        /// <typeparam name="T">type parameter of generic class HasId.</typeparam>
        /// <param name="updatedRecord">New version of a record, to be updated in database.</param>
        /// <param name="file">the database file to be searched for matching record.</param>
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

        private void CreateAdminIfNotExists()
        {
            var users = ReadRecords<UserRecord>(StorageFile.users);
            if (!users.Any(u => u.Role == UserConstants.ManagerRole))
            {
                UserFactory.CreateUser("adminf@airview.com", "admin", "account", "admin", UserConstants.ManagerRole);
            }
        }
    }
}