using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4_1.VersionController.Changes;

namespace Task4_1.VersionController
{
    public class FileVersionWatcher
    {
        public Action<object, Change> Changed = (object sender, Change ch) => { };
        public Action<object> Started = (object sender) => { };
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
                return;

            FileInfo file = new FileInfo(e.FullPath);

            if (!file.Exists)
                throw new FileNotFoundException();

            StreamReader sr = new StreamReader(file.OpenRead());
            try
            {
                string fileContainments = sr.ReadToEnd();
                sr.Close();

                Change ch = new Change(file, DateTime.Now, fileContainments);
                Changed?.Invoke(this, ch);

                Log.Debug($"{e.Name} has been changed");
            }
            catch (Exception ex)
            {
                sr.Close();

                throw ex;
            }
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);

            if (!file.Exists)
                throw new FileNotFoundException();

            Change ch = new Change(file, DateTime.Now);
            Changed?.Invoke(this, ch);

            Log.Debug($"{e.Name} has been created");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            FileInfo file = new FileInfo(e.FullPath);

            Change ch = new Change(file, DateTime.Now, true);
            Changed?.Invoke(this, ch);

            Log.Debug($"{e.Name} has been deleted");
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            FileInfo oldFile = new FileInfo(e.OldFullPath);

            Change oldCh = new Change(oldFile, DateTime.Now, true);
            Changed?.Invoke(this, oldCh);

            FileInfo file = new FileInfo(e.FullPath);

            if (!file.Exists)
                throw new FileNotFoundException();

            StreamReader sr = new StreamReader(e.FullPath);
            try
            {
                string fileContainments = sr.ReadToEnd();
                sr.Close();

                Change ch = new Change(file, DateTime.Now, fileContainments);
                Changed?.Invoke(this, ch);

                Log.Debug($"{e.OldName} has been renamed to {e.Name}");
            }
            catch (Exception ex)
            {
                sr.Close();

                throw ex;
            }
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            throw new Exception(e.GetException().Message);
        }

        public void StartWatch(string directoryToControl)
        {
            Started(this);

            FileSystemWatcher watcher = new FileSystemWatcher(directoryToControl);

            watcher.Filter = "*.txt";

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        public void Save(string fileToLog, ChangesContainer loggedChanges)
        {
            string loggedJson = Newtonsoft.Json.JsonConvert.SerializeObject(loggedChanges);

            FileInfo logsFile = new FileInfo(fileToLog);

            StreamWriter sw = new StreamWriter(fileToLog);

            if (!logsFile.Exists)
            {
                sw = logsFile.CreateText();
                sw.Close();
                return;
            }

            sw.Write(loggedJson);
            sw.Close();
        }
    }
}
