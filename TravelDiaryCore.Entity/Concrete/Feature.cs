using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;

namespace TravelDiaryCore.Entity.Concreate
{
    public class Feature : IEntity
    {
        [Key]
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; } 
        public bool IsPrimary { get; set; } 

    }
}
