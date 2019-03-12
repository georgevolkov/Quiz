using QuestionsApplication.DAL;
using QuestionsApplication.Models;
using System.Configuration;

public class RepositoryBase 
{
   protected readonly ApplicationDbContext MyContext;
   public RepositoryBase()
   {
      MyContext = new ApplicationDbContext();
   }
}