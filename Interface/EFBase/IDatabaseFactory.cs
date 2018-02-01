using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.EFBase
{
    public interface IDatabaseFactory : IDisposable
    {
        testEntities Get();
    }
}
