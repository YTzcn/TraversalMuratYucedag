using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;
using TravelDiaryCore.Entity.Concrete;

namespace TravelDiaryCore.Entity.Concreate
{
    public class Destination : IEntity
    {
        [Key]
        public int DestinationId { get; set; }
        public string City{ get; set; }
        public  string  DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description{ get; set; }
        public int Capacity{ get; set; }
        public bool Status{ get; set; }
        public string Title{ get; set; }
        public string CoverImage{ get; set; }
        public string Content{ get; set; }
        public List<Comment> Comments{ get; set; }

    }
}
