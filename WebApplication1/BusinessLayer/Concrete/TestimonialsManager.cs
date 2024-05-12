using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialsManager:ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialsManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public List<Testimonials> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void TAdd(Testimonials t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonials t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonials TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public void TUpdate(Testimonials t)
        {
            _testimonialDal.Upadate(t);
        }
    }
}
