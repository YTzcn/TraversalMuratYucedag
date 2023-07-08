using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDiaryCore.Entity.Abstract;
using TravelDiaryCore.Entity.Concreate;

namespace TravelDiaryCore.Entity.Concrete
{
    public class Comment:IEntity
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate{ get; set; }
        public string CommentContet{ get; set; }
        public bool CommentState{ get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
