using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1.VersionController.Changes
{
    public class ChangesContainer
    {
        public ChangesContainer()
        {
            Changes = new List<Change>();
        }

        public List<Change> Changes
        {
            get;
            set;
        }
    }
}
