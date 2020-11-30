using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
   public class Tbl_AdManager : ITbl_AdService
    {
        private ITbl_AdDal _Tbl_AdDal;

        public Tbl_AdManager(ITbl_AdDal Tbl_AdDal)
        {
            _Tbl_AdDal = Tbl_AdDal;
        }
        public void Add(Tbl_Ad Parameter)
        {
            _Tbl_AdDal.Add(Parameter);
        }

        public void Delete(Tbl_Ad Parameter)
        {
            _Tbl_AdDal.Delete(Parameter);
        }

        public Tbl_Ad Get(int Parameter)
        {
            return _Tbl_AdDal.Get(x => x.AdID == Parameter);
        }

        public List<Tbl_Ad> GetAll()
        {
            return _Tbl_AdDal.GetList();
        }

        public void Update(Tbl_Ad Parameter)
        {
            _Tbl_AdDal.Update(Parameter);
        }
    }
}
