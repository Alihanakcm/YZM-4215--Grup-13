using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfView_AdGeneralInfoDal : EfEntityRepositoryBase<View_AdGeneralInfo, Context>, IView_AdGeneralInfoDal
    {
    }
}
