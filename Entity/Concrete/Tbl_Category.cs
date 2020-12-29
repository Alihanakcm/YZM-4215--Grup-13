using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Tbl_Category : IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
