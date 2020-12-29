using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public  class View_AdInfoManager : IView_AdInfoService
    {
        private IView_AdInfoDal _View_AdInfoDal;

        public View_AdInfoManager(IView_AdInfoDal View_AdInfoDal)
        {
            _View_AdInfoDal = View_AdInfoDal;
        }
        public void Add(View_AdInfo Parameter)
        {
            _View_AdInfoDal.Add(Parameter);
        }

        public void Delete(View_AdInfo Parameter)
        {
            _View_AdInfoDal.Delete(Parameter);
        }

        public View_AdInfo Get(int Parameter)
        {
            return _View_AdInfoDal.Get(x => x.AdID == Parameter);
        }

        public List<View_AdInfo> GetAll()
        {
            return _View_AdInfoDal.GetList();
        }

        public void Update(View_AdInfo Parameter)
        {
            _View_AdInfoDal.Update(Parameter);
        }
    }
}
