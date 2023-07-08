using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;

namespace TravelDiaryCore.Entity.Concreate
{
    public class SubAbout : IEntity
    {
        [Key]
        public int SubAboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
