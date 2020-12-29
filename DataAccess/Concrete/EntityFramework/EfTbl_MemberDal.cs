using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_MemberDal : EfEntityRepositoryBase<Tbl_Member,Context>, ITbl_MemberDal
    {
    }
}
