using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorks
{
    public interface UnitOfWork
    {
        public Task Begin();
        public Task Commit();
        public Task RollBack();
        public Task Complete();
    }
}
