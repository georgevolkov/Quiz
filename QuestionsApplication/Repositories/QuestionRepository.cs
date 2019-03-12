using QuestionsApplication.DAL.Entities;
using QuestionsApplication.Repositories.Base;
using System.Collections.Generic;

namespace QuestionsApplication.Repositories
{
   public class QuestionRepository : RepositoryBase, IRepository<Question>
   {
      public bool Add(Question model)
      {
         MyContext.Questions.Add(model);
         return MyContext.SaveChanges() != 0;
      }

      public IEnumerable<Question> GetRecords()
      {
         return MyContext.Questions;
      }
   }
}