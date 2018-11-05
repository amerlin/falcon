using System.Collections.Generic;

namespace FalconLib.Abstract
{
    public interface IRepository<T> where T: class
    {
         IEnumerable<T> GetAll();
         void Save(IEnumerable<T> elements);
         void Delete(IEnumerable<T> elements);
         
    }
}