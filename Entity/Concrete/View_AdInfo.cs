using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class View_AdInfo : IEntity
    {
        [Key]
        public int AdID { get; set; }
        public string AdTitle { get; set; }
        public string AdInfo { get; set; }
        public string CategoryName { get; set; }
        public string MemberName { get; set; }
        public int MemberID { get; set; }
        public string MemberSurname { get; set; }
        public string MemberMail { get; set; }
        public string CityName { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public DateTime AdDate { get; set; }
    }
}
