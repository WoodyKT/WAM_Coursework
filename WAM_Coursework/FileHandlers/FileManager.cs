using CsvHelper;
using System;
using System.Globalization;
using System.IO;

namespace WAM_Coursework.FileHandlers
{
    public sealed class FileManager
    {

        private const string usersHeader = "email,firstName,lastName,passwordHash,role,relevantConferenceIds";
        private const string conferencesHeader = "id,name,description,datetime,reviewers,status";

        FileManager()
        {
            CreateFileIfNotExists();
        }

        public enum StorageFile
        {
            users,
            conferences
        };

        private static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "FairView");

        public static readonly FileManager Instance = new FileManager();

        private static string GetDir(StorageFile file)
        {
            string fileName=string.Empty;
            switch (file)
            {
                case StorageFile.users:
                    fileName = "users.csv";
                    break;
                case StorageFile.conferences:
                    fileName= "conferences.csv";
                    break;
                default:
                    break;
            }
            var path = Path.Combine(basePath, fileName);
            Directory.CreateDirectory(path);
            return path;
        }

        #region Read/Write
        public static string GetFromFile(string valueToSearch, StorageFile file)
        {
            StreamReader reader = new StreamReader(GetDir(file));
            CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            string result = csvReader.GetRecord(valueToSearch);

            return result;
        }

        public static void WriteToFile(string valueToSave, StorageFile file)
        {
            StreamWriter writer = new StreamWriter(GetDir(file));
            CsvWriter csvwriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvwriter.WriteField(valueToSave, true);
        }

        #endregion

        private void CreateFileIfNotExists()
        {
            if (!File.Exists(GetDir(StorageFile.users)))
            {
                using (var stream = File.Create(GetDir(StorageFile.users)))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(usersHeader);
                }
            }
            if (!File.Exists(GetDir(StorageFile.conferences)))
            {
                using (var stream = File.Create(GetDir(StorageFile.conferences)))
                {
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(conferencesHeader);
                }
            }
        }
    }
}
