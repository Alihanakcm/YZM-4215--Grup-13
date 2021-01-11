using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class View_Message :IEntity
    {
        [Key]
        public int MessageID { get; set; }
        public int RequestID { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
        public int MessageRequestID { get; set; }
        public string RequestMemberNickName { get; set; }
        public string RequestMemberName { get; set; }
        public string RequestMemberSurname { get; set; }
        public string AdTitle { get; set; }
        public int AdID { get; set; }
        public string AdInfo { get; set; }
        public string CategoryName { get; set; }
        public string MemberName { get; set; }
        public string MemberNickName { get; set; }
        public int MemberID { get; set; }
        public string MemberSurname { get; set; }
        public string MemberMail { get; set; }
        public string CityName { get; set; }
        public string RequestNameState { get; set; }
        public int RequestMemberID { get; set; }
        public int CategoryID { get; set; }

    }
}
