namespace Fabrikam.Core
{
    public interface IPartitionKeyGenerator
    {
        string Get(string setId);
    }

    class PartitionKeyGenerator : IPartitionKeyGenerator
    {
        public string Get(string setId)
        {
            return $"setId:{setId}";
        }
    }
}
