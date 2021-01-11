using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_RequestDal : EfEntityRepositoryBase<Tbl_Request,Context>, ITbl_RequestDal
    {
    }
}
