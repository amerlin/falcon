using FalconLib.Abstract;
using FalconLib.Concrete.Model;
using System.Collections.Generic;

namespace FalconLib.Concrete.Repository
{
    public class FeedRepository<T> : IRepository<RemoteFeedElement> 
    {
        public void Delete(IEnumerable<RemoteFeedElement> elements)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RemoteFeedElement> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Save(IEnumerable<RemoteFeedElement> elements)
        {
            throw new System.NotImplementedException();
        }
    }
}