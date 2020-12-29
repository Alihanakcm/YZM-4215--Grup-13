using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class View_AdGeneralInfo : IEntity
    {
        [Key]
        public int RequestID { get; set; }
        public string AdTitle { get; set; }
        public int AdID { get; set; }
        public string AdInfo { get; set; }
        public string CategoryName { get; set; }
        public string MemberName { get; set; }
        public int MemberID { get; set; }
        public string MemberSurname { get; set; }
        public string MemberMail { get; set; }
        public string CityName { get; set; }
        public string RequestNameState { get; set; }
        public int RequestMemberID { get; set; }
        public int CategoryID { get; set; }
        
    }
}
