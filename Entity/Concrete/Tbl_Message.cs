using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
  public  class Tbl_Message : IEntity
    {
        [Key]
        public int MessageID { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
        public int MessageRequestID { get; set; }
        public int SenderMemberID { get; set; }
    }
}
