using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
   public class Context : DbContext
    {
       public virtual DbSet<Tbl_Ad> Tbl_Ad { get; set; }
        public virtual DbSet<Tbl_AdRole> Tbl_AdRole { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_List> Tbl_List { get; set; }
        public virtual DbSet<Tbl_Member> Tbl_Member { get; set; }
        public virtual DbSet<Tbl_City> Tbl_City { get; set; }
        public virtual DbSet<Tbl_Request> Tbl_Request { get; set; }
        public virtual DbSet<Tbl_RequestState> Tbl_RequstState { get; set; }
        public virtual DbSet<View_AdGeneralInfo> View_AdGeneralInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=BirElinVerdigi; Integrated Security=True;");
            }
        }


    }
}
