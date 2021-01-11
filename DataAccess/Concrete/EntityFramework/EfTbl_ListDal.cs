using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_ListDal : EfEntityRepositoryBase<Tbl_List,Context>, ITbl_ListDal
    {
    }
}
