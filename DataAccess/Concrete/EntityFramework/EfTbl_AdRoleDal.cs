using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_AdRoleDal : EfEntityRepositoryBase<Tbl_AdRole,Context>, ITbl_AdRoleDal
    {
    }
}
