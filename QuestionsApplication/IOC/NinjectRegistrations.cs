using Ninject.Modules;
using QuestionsApplication.DAL.Entities;
using QuestionsApplication.Repositories;
using QuestionsApplication.Repositories.Base;

namespace QuestionsApplication.IOC
{
   public class NinjectRegistrations : NinjectModule
   {
      public override void Load()
      {
         Bind<IRepository<Answer>>().To<AnswerRepository>();
         Bind<IRepository<Question>>().To<QuestionRepository>();
      }
   }
}