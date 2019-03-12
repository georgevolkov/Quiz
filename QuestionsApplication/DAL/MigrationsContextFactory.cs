using QuestionsApplication.Models;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace QuestionsApplication.DAL
{
   public class MigrationsContextFactory : IDbContextFactory<ApplicationDbContext>
   {
      public ApplicationDbContext Create()
      {
         return new ApplicationDbContext();
      }
   }
}