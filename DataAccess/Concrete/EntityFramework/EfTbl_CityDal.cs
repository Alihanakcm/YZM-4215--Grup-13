using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public  class EfTbl_CityDal : EfEntityRepositoryBase<Tbl_City, Context>, ITbl_CityDal
    {
    }
}
