using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace SuperFolio.ViewComponents.Testimonials
{
    public class TestimonialsList:ViewComponent
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.GetList();
            return View(values);
        }
    }
}
