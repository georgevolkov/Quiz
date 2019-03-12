using QuestionsApplication.DAL.Entities;
using QuestionsApplication.Repositories.Base;
using System.Web.Mvc;

namespace QuestionsApplication.Controllers
{
    public class QuestionsController : Controller
    {
        private IRepository<Question> _questionsRepository;
        public QuestionsController(IRepository<Question> questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        public ActionResult Index()
        {
            return View(_questionsRepository.GetRecords());
        }
    }
}