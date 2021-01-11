using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfView_MessageDal : EfEntityRepositoryBase<View_Message, Context>, IView_MessageDal
    {
    }
}
