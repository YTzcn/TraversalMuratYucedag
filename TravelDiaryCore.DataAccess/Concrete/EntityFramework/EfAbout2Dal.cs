﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.DataAccess.Concrete.EntityFramework
{
    public class EfAbout2Dal : EfEntityRepositoryBase<About2, TravelDiaryContext>,IAbout2Dal
    {
    }
}