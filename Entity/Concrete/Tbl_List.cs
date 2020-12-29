using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_List:IEntity
    {
        [Key]
        public int ListID { get; set; }
        public int MemberID { get; set; }
        public int AdID { get; set; }
    }
}
