using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;

namespace TravelDiaryCore.Entity.Concreate
{
    public class Feature2 : IEntity
    {
        [Key]
        public int Feature2Id { get; set; }
        public int Feature2Description { get; set; }
    }
}
