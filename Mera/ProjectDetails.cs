using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Mera
{
    class ProjectDetails
    {
        public static bool projectSet = false;
        public static int numOfProjects = 0;
        public static int currentProject = -1;

        public static List<Classes.Project> projectsList = new List<Classes.Project>();

        public void ConnectToDatabase()
        {

            var client = new MongoClient("mongodb+srv://bavakumaravel:<krishna108>@xm-mera-hsm4n.azure.mongodb.net/<MeraProjects>?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");

        }
    }
}
