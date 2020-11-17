using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfView_AdGeneralInfoDal : EfEntityRepositoryBase<View_AdGeneralInfo, Context>, IView_AdGeneralInfoDal
    {
    }
}
