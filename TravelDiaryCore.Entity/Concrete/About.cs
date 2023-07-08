using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;

namespace TravelDiaryCore.Entity.Concreate
{
    public class About : IEntity
    {
        [Key]
        public int AboutId { get; set; }
        public string Title{ get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image1 { get; set; }
        public bool Status{ get; set; }
    }
}
