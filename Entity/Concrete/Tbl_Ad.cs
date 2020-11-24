using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_Ad: IEntity
    {
        [Key]
        public int AdID { get; set; }
        public string AdTitle { get; set; }
        public string AdInfo { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public string AdState { get; set; }
        public int MemberID { get; set; }
        public int AdRoleID { get; set; }
    }
}
