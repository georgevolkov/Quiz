using QuestionsApplication.Models;
using System.ComponentModel;

namespace QuestionsApplication.DAL.Entities
{
   public class Answer
   {
      public int Id { get; set; }
      [DisplayName("Question")]
      public virtual Question Question { get; set; }
      public System.Guid UserId { get; set; }
      public virtual ApplicationUser User { get; set; }
      public string UserAnswer { get; set; }
   }
}