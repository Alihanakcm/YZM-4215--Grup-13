using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_Request:IEntity
    {
        [Key]
        public int RequestID { get; set; }
        public int MemberID { get; set; }
        public int AdID { get; set; }
        public int RequestStateID { get; set; }
        
    }
}
