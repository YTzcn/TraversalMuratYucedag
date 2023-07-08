using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.Entity.Abstract;
using TravelDiaryCore.Entity.Concreate;
using TravelDiaryCore.Entity.Concrete;

namespace TravelDiaryCore.DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, TravelDiaryContext>,ICommentDal
    {
    }
}
