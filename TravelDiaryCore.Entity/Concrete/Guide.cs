using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;

namespace TravelDiaryCore.Entity.Concreate
{
    public class Guide : IEntity
    {
        [Key]
        public int GuidId { get; set; }
        public string GuideName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status{ get; set; }
    }
}
