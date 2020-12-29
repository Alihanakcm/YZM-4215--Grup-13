using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Tbl_RequestState:IEntity
    {
        [Key]
        public int RequestStateID { get; set; }
        public string RequestNameState { get; set; }
    }
}
