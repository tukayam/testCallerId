using System.Collections.Generic;
using System.Linq;
using Fabrikam.Core;

namespace Fabrikam.Web
{
    public interface IRequestRepository
    {
        IEnumerable<RequestEntity> Get(string setId);
    }

    class RequestRepository : IRequestRepository
    {
        private readonly IRepository<RequestEntity> _repository;
        private readonly IPartitionKeyGenerator _partitionKeyGenerator;

        public RequestRepository(IRepository<RequestEntity> repository,
                                 IPartitionKeyGenerator partitionKeyGenerator)
        {
            _repository = repository;
            _partitionKeyGenerator = partitionKeyGenerator;
        }

        public IEnumerable<RequestEntity> Get(string setId)
        {
            var partitionKey = _partitionKeyGenerator.Get(setId);
            var requests = _repository.GetAllInPartition(partitionKey)?.ToList();

            return requests;
        }
    }
}
