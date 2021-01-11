using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfTbl_RequestStateDal :EfEntityRepositoryBase<Tbl_RequestState,Context>, ITbl_RequestStateDal
    {
    }
}
