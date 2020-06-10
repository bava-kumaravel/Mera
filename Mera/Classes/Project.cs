using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mera.Classes
{
    public class Project
    {
        string projectName;
        int projectId;
        double projectCost;

        public Project(string _projectName, int _projectId)
        {
            projectName = _projectName;
            projectId = _projectId;
            projectCost = 0;
        }
    }
}
