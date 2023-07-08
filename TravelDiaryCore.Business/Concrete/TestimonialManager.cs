using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
                _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
            _testimonialDal.Add(testimonial);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial GetById(int Id)
        {
            return _testimonialDal.GetById(x => x.TestimonialId == Id);
        }

        public void Remove(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);
        }

        public void Update(Testimonial testimonial)
        {
            _testimonialDal.Update(testimonial);
        }
    }
}
