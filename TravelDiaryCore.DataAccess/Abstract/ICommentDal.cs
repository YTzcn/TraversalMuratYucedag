﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concrete;

namespace TravelDiaryCore.DataAccess.Abstract
{
    public interface ICommentDal:IEntityRepository<Comment>
    {
    }
}
