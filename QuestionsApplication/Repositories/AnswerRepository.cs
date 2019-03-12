using QuestionsApplication.DAL.Entities;
using QuestionsApplication.Repositories.Base;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System;
using System.Linq;

namespace QuestionsApplication.Repositories
{
    public class AnswerRepository : RepositoryBase, IRepository<Answer>
   {
      public bool Add(Answer model)
      {
         return MyContext.Answers.Add(model) != null;
      }

      public void Update(Answer model)
      {
          MyContext.Answers.AddOrUpdate(model);
      }

      public IEnumerable<Answer> GetRecords()
      {
         return MyContext.Answers;
      }

      internal IEnumerable<Answer> GetAnswersByUser(Guid userId)
      {
          return MyContext.Answers.Where(x => x.UserId == userId);
      }

      public bool Save()
      {
         return MyContext.SaveChanges() != 0;
      }
   }
}