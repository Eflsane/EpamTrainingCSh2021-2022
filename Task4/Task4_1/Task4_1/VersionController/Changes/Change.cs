using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1.VersionController.Changes
{
    public class Change
    {
        public Change()
        {
            
        }

        public Change(FileInfo file, DateTime changeDateTime)
        {
            ChangeID = Guid.NewGuid();
            File = file;
            ChangeDateTime = changeDateTime;
            CreationTime = file.CreationTime;
            Attributes = file.Attributes;
        }

        public Change(FileInfo file, DateTime changeDateTime, string fileContainment) : this(file, changeDateTime)
        {
            FileContainment = fileContainment;
        }

        public Change(FileInfo file, DateTime changeDateTime, bool isDeleted = true) : this(file, changeDateTime)
        {
            IsDeleted = isDeleted; 
        }

        public Change(Guid changeID,
            FileInfo file,
            DateTime changeDateTime,
            string fileContainment,
            bool isDeleted,
            DateTime creationTime,
            FileAttributes attributes)
        {
            ChangeID = changeID;
            File = file;
            ChangeDateTime = changeDateTime;
            FileContainment = fileContainment;
            IsDeleted = isDeleted;
            CreationTime = creationTime;
            Attributes = attributes;
        }

        public Guid ChangeID
        {
            get;
            set;
        }

        public FileInfo File
        {
            get;
            set;
        }

        public DateTime ChangeDateTime
        {
            get;
            set;
        }

        public string FileContainment
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        } = false;

        public DateTime CreationTime
        {
            get;
            set;
        }
        
        public FileAttributes Attributes
        {
            get;
            set;
        }
    }
}
