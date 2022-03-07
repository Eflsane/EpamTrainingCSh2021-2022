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
    public class FileVersionController
    {
        private ChangesContainer _loggedChanges;

        private FileVersionWatcher _versionWatcher;
        private FileVersionReverter _versionReverter;

        public FileVersionController(string directoryToControll, string fileToLog)
        {
            DirectoryToControl = directoryToControll;
            FileToLog = fileToLog;
            _loggedChanges = new ChangesContainer();

            _versionWatcher = new FileVersionWatcher();
            _versionWatcher.Changed += OnChanged;
            _versionWatcher.Started += OnStarted;

            _versionReverter = new FileVersionReverter();
            _versionReverter.Started += OnStarted;
        }

        public string DirectoryToControl
        {
            get;
            set;
        }

        public string FileToLog
        {
            get;
            set;
        }

        private void OnStarted(object sender)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            if (!File.Exists(FileToLog))
                return;
            if (File.ReadAllText(FileToLog) == string.Empty)
                return;

            FileInfo file = new FileInfo(FileToLog);

            StreamReader sr = new StreamReader(FileToLog);
            _loggedChanges = Newtonsoft.Json
                .JsonConvert
                .DeserializeObject<ChangesContainer>
                (sr.ReadToEnd());
            sr.Close();
        }

        private void OnChanged(object sender, Change ch)
        {
            _loggedChanges.Changes.Add(ch);
        }

        public void WatchForChanges()
        {
            _versionWatcher.StartWatch(DirectoryToControl);
        }

        public void SaveLogs()
        {
            _versionWatcher.Save(FileToLog, _loggedChanges);
        }

        public void RevertChanges(DateTime dateTimeToReturn)
        {
            _versionReverter.RevertChanges(dateTimeToReturn, ref _loggedChanges);
        }

        public void ClearLogs()
        {
            _loggedChanges = new ChangesContainer();
        }
    }
}
