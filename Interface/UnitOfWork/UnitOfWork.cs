using Entity;
using Interface.EFBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Interface.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private testEntities dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected testEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void TranCommit(Action func)
        {  //开启事务
            using (var tran = new TransactionScope())
            {
                try
                {
                    func();
                    DataContext.SaveChanges();
                    tran.Complete();
                  
                  
                }
                catch (Exception ex)
                {
                    tran.Dispose();
                }

            }

        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }

        public void CommitAsync()
        {
            DataContext.SaveChangesAsync();
        }


    }
}
