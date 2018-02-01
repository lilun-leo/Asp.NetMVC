using Entity;
using Interface;
using Interface.EFBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Server
{

    public class UserRepo : EFRepositoryBase<UserInfo>, IUserInfoRepo
    {
        public UserRepo(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
           
        }

        

    }
}
