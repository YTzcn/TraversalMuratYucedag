using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.Entity.Concrete;

namespace TravelDiaryCore.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public Comment GetById(int Id)
        {
            return _commentDal.GetById(x=>x.CommentId == Id);
        }

        public void Remove(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
