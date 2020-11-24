using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfView_AdInfoDal : EfEntityRepositoryBase<View_AdInfo, Context>, IView_AdInfoDal
    {
    }
}
