using System;
using System.Collections.Generic;

namespace Fabrikam.Core
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAllInPartition(string partitionKey);
    }

    class Repository<T> : IRepository<T>
    {
        public IEnumerable<T> GetAllInPartition(string partitionKey)
        {
            throw new NotImplementedException();
        }
    }
}
