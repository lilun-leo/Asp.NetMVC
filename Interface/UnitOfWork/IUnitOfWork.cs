﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void CommitAsync();
        void TranCommit(Action func);
    }
}
