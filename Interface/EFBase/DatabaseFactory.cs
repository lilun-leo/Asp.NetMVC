using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.EFBase
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private testEntities dataContext;

        public testEntities Get()
        {
            return dataContext ?? (dataContext = new testEntities());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
       
    }
}
