using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class View_AdGeneralInfoManager : IView_AdGeneralInfoService
    {
        private IView_AdGeneralInfoDal _View_AdGeneralInfoDal;

        public View_AdGeneralInfoManager(IView_AdGeneralInfoDal View_AdGeneralInfoDal)
        {
            _View_AdGeneralInfoDal = View_AdGeneralInfoDal;
        }
        public void Add(View_AdGeneralInfo Parameter)
        {
            _View_AdGeneralInfoDal.Add(Parameter);
        }

        public void Delete(View_AdGeneralInfo Parameter)
        {
            _View_AdGeneralInfoDal.Delete(Parameter);
        }

        public View_AdGeneralInfo Get(int Parameter)
        {
            return _View_AdGeneralInfoDal.Get(x => x.AdID == Parameter);
        }

        public List<View_AdGeneralInfo> GetAll()
        {
            return _View_AdGeneralInfoDal.GetList();
        }

        public void Update(View_AdGeneralInfo Parameter)
        {
            _View_AdGeneralInfoDal.Update(Parameter);
        }
    }
}
