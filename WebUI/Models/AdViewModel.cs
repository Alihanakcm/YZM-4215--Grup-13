using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AdViewModel
    {
        public List<Tbl_Ad> ads { get; set; }
        public Tbl_Ad ad { get; set; }
        public List<Tbl_City> allCity { get; set; }
        public List<Tbl_Category> allCategories { get; set; }
        public List<View_AdGeneralInfo> AdInfo { get; set; }
        public int MemberID { get; set; }
    }
}
