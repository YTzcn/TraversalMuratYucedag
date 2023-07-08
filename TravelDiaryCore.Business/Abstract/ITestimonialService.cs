using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Business.Abstract
{
    public interface ITestimonialService
    {

        List<Testimonial> GetAll();
        Testimonial GetById(int Id);
        void Add(Testimonial testimonial);
        void Remove(Testimonial testimonial);
        void Update(Testimonial testimonial);
    }
}
