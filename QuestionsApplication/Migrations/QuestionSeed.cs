using System.Collections.Generic;
using QuestionsApplication.Models;
using System.Data.Entity;
using QuestionsApplication.DAL.Entities;

namespace QuestionsApplication.Migrations
{
    public class QuestionSeed : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            IList<Question> questions = new List<Question>();

            questions.Add(new Question() { QuestionText = "Введите имя", QuestionType = QuestionTypeEnum.String });
            questions.Add(new Question() { QuestionText = "Введите возраст", QuestionType = QuestionTypeEnum.Integer });
            questions.Add(new Question() { QuestionText = "Введите пол", QuestionType = QuestionTypeEnum.Enumeration });
            questions.Add(new Question() { QuestionText = "Введите дату", QuestionType = QuestionTypeEnum.DateTime });
            questions.Add(new Question() { QuestionText = "Введите семейное положение", QuestionType = QuestionTypeEnum.Enumeration });
            questions.Add(new Question() { QuestionText = "Любите ли вы программировать", QuestionType = QuestionTypeEnum.Boolean });

            context.Questions.AddRange(questions);

            base.Seed(context);
        }
    }
}