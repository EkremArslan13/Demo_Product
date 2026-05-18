using BusinessLayer.Concrete;
using BusinessLayer.FluentValuedation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productmanager = new ProductManager(new EfProductDal());

        public IActionResult Index()
        {
            var values  = productmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
           

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
             productmanager.TInsert(p);
            
              return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
          
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = productmanager.TGetById(id);
            productmanager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = productmanager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p) 
        {
          
            productmanager.TUpdate(p);
            return RedirectToAction("Index");
         
        }
    }
}
