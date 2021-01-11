using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_CategoryDal : EfEntityRepositoryBase<Tbl_Category,Context>, ITbl_CategoryDal
    {
    }
}
