using System.Collections.Generic;

namespace QuestionsApplication.Repositories.Base
{
   public interface IRepository<T>
   {
      bool Add(T model);
      IEnumerable<T> GetRecords();
   }
}