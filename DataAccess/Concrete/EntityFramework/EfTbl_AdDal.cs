using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_AdDal : EfEntityRepositoryBase<Tbl_Ad,Context>, ITbl_AdDal
    {
    }
}
