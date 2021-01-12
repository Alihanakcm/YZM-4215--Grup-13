using Entity.Concrete;

namespace Business.Abstract
{
   public interface ITbl_MemberService : IServices<Tbl_Member>
    {
        Tbl_Member LoginControlGet(int IDNumberr, string MemberPassword);
    }
}
