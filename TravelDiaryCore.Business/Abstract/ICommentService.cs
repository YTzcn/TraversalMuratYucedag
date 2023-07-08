using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;
using TravelDiaryCore.Entity.Concrete;

namespace TravelDiaryCore.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll();
        Comment GetById(int Id);
        void Add(Comment comment);
        void Remove(Comment comment);
        void Update(Comment comment);
    }
}
