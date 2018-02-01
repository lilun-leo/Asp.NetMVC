using Entity;
using Interface;
using Interface.EFBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ProjectRepo : EFRepositoryBase<Project>, IProjectRepo
    {
        public ProjectRepo(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }

    }
}
