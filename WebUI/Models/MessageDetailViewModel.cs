using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class MessageDetailViewModel
    {
        public List<View_Message> allMessages { get; set; }
        public View_Message message { get; set; }
        public List<View_Message> messageCount { get; set; }
        public List<Tbl_Message> messages { get; set; }
        public Tbl_Message messageSend { get; set; }
        public int memberID { get; set; }
    }
}
