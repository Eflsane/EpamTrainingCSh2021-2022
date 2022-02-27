using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4_1.VersionController.Changes;

namespace Task4_1.VersionController
{
    public class FileVersionReverter
    {
        public Action<object> Started = (object sender) => { };

        public void RevertChanges(DateTime dateTimeToReturn, ref ChangesContainer loggedChanges)
        {
            Started?.Invoke(this);
            if (loggedChanges.Changes.Count <= 0)
                throw new InvalidOperationException("Logs are empty");

            IEnumerable<Change> changesBeforeDate = loggedChanges.Changes.Where(x => x.ChangeDateTime <= dateTimeToReturn)
                .OrderByDescending(x => x.ChangeDateTime);
            List<Change> lastChanges = new List<Change>();
            foreach (Change ch in changesBeforeDate)
            {
                if (lastChanges.Any(x => x.File.FullName == ch.File.FullName))
                    continue;

                lastChanges.Add(ch);

                if (ch.IsDeleted)
                {
                    if (!ch.File.Exists)
                        continue;

                    ch.File.Delete();

                    continue;
                }

                StreamWriter sr;

                sr = ch.File.CreateText();
                sr.Write(ch.FileContainment);
                sr.Close();
                ch.File.Attributes = ch.Attributes;
                ch.File.CreationTime = ch.CreationTime;
                ch.File.LastWriteTime = ch.ChangeDateTime;
                ch.File.LastAccessTime = ch.ChangeDateTime;
            }

            IEnumerable<Change> changesAfterDate = loggedChanges.Changes.Where(x => x.ChangeDateTime > dateTimeToReturn)
                .OrderByDescending(x => x.ChangeDateTime);

            foreach (Change ch in changesAfterDate)
            {
                if (lastChanges.Any(x => x.File.FullName == ch.File.FullName))
                    continue;

                if (!ch.File.Exists)
                    continue;

                ch.File.Delete();
            }
        }
    }
}
