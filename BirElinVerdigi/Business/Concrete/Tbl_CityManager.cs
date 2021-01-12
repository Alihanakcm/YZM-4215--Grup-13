using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
   public  class Tbl_CityManager : ITbl_CityService
    {
        private ITbl_CityDal _Tbl_CityDal;

        public Tbl_CityManager(ITbl_CityDal Tbl_CityDal)
        {
            _Tbl_CityDal = Tbl_CityDal;
        }
        public void Add(Tbl_City Parameter)
        {
            _Tbl_CityDal.Add(Parameter);
        }

        public void Delete(Tbl_City Parameter)
        {
            _Tbl_CityDal.Delete(Parameter);
        }

        public Tbl_City Get(int Parameter)
        {
            return _Tbl_CityDal.Get(x => x.CityID == Parameter);
        }

        public List<Tbl_City> GetAll()
        {
            return _Tbl_CityDal.GetList();
        }

        public void Update(Tbl_City Parameter)
        {
            _Tbl_CityDal.Update(Parameter);
        }
    }
}
