using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_Member:IEntity
    {
        [Key]
        public int MemberID { get; set; }
        public int IDNumber { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberMail { get; set; }
        public string MemberPassword { get; set; }
       
    }
}
