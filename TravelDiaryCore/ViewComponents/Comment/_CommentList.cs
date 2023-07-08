using Microsoft.AspNetCore.Mvc;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.DependencyResolvers.Ninject;

namespace TravelDiaryCore.MVC.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        private ICommentService _commentService;
        public _CommentList()
        {
            _commentService = InstanceFactory.GetInstance<ICommentService>(new BussinesModule());
        }

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
