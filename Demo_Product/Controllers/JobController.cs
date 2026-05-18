using BusinessLayer.Concrete;
using BusinessLayer.FluentValuedation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobmanager = new JobManager(new EfJobDal());

        public IActionResult Index()
        {
            var values = jobmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {


            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            JobValidator validationRules = new JobValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                jobmanager.TInsert(p);

                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        public IActionResult DeleteJob(int id)
        {
            var value = jobmanager.TGetById(id);
            jobmanager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobmanager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateJob(Job p)
        {

            jobmanager.TUpdate(p);
            return RedirectToAction("Index");

        }
    }
}
