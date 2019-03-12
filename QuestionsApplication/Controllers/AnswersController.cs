using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using QuestionsApplication.DAL.Entities;
using QuestionsApplication.Repositories;
using QuestionsApplication.Repositories.Base;
using QuestionsApplication.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace QuestionsApplication.Controllers
{
    public class AnswersController : Controller
    {
        private AnswerRepository _answersRepository;
        private QuestionRepository _questionsRepository;

        public AnswersController(IRepository<Answer> answersRepository, IRepository<Question> questionsRepository)
        {
            _answersRepository = answersRepository as AnswerRepository;
            _questionsRepository = questionsRepository as QuestionRepository;
        }

        public ActionResult Index()
        {
            var strId = User.Identity.GetUserId();
            if (string.IsNullOrEmpty(strId))
                throw new UserAuthentificateException();
            var id = new Guid();
            if (id == null)
                throw new UserAuthentificateException();

            var data = new List<AnswersWithData>();

            var user = getApplicationUser();
            
            foreach (var question in _questionsRepository.GetRecords())
            {
                data.Add(new AnswersWithData(question, new Answer()
                {
                    UserId = id, User = user, Question = question
                }));
            }
            
            return View(data);
        }

        public ActionResult Next(int id)
        {
            // TODO: If repository contains enity Update else Add item
            return View(/*Pass next Id*/);
        }

        public ActionResult Previous(int id)
        {
            // TODO: If repository contains enity Update
            return View(/*Pass previous Id*/);
        }

        private ApplicationUser getApplicationUser()
        {
            var store = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userManager = new UserManager<ApplicationUser>(store);
            ApplicationUser user = userManager.FindByNameAsync(User.Identity.Name).Result;
            return user;
        }

        public class AnswersWithData
        {
            public AnswersWithData(Question question, Answer answers)
            {
                Question = question;
                Answer = answers;
            }

            public Question Question { get; set; }
            public Answer Answer{get; set; }

        }

        public class UserAuthentificateException : Exception
        {
            public UserAuthentificateException() : base("Пользователь не аутентифицирован")
            {
            }
        }
    }
}