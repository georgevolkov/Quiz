using System.ComponentModel;

namespace QuestionsApplication.DAL.Entities
{
   public class Question
   {
      public int Id { get; set; }
      [DisplayName("Question text")]
      public string QuestionText { get; set; }
      public QuestionTypeEnum QuestionType { get; set; }
   }
}