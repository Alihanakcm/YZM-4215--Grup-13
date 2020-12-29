using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfTbl_MessageDal : EfEntityRepositoryBase<Tbl_Message, Context>, ITbl_MessageDal
    {
    }
}
