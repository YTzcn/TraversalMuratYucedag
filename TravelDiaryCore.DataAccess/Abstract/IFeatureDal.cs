﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.DataAccess.Abstract
{
    public interface IFeatureDal : IEntityRepository<Feature>
    {
    }
}