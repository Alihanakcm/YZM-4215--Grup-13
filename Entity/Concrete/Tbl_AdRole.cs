using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_AdRole:IEntity
    {
        [Key]
        public int AdRoleID { get; set; }
        public string Name { get; set; }

    }
}
