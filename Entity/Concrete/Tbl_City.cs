using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Tbl_City : IEntity
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
    }
}
