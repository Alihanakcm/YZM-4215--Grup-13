using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_RequestManager : ITbl_RequestService
    {
        private ITbl_RequestDal _Tbl_RequestDal;

        public Tbl_RequestManager(ITbl_RequestDal Tbl_RequestDal)
        {
            _Tbl_RequestDal = Tbl_RequestDal;
        }
        public void Add(Tbl_Request Parameter)
        {
            _Tbl_RequestDal.Add(Parameter);
        }

        public void Delete(Tbl_Request Parameter)
        {
            _Tbl_RequestDal.Delete(Parameter);
        }

        public Tbl_Request Get(int Parameter)
        {
            return _Tbl_RequestDal.Get(x => x.RequestID == Parameter);
        }

        public List<Tbl_Request> GetAll()
        {
            return _Tbl_RequestDal.GetList();
        }

        public void Update(Tbl_Request Parameter)
        {
            _Tbl_RequestDal.Update(Parameter);
        }
    }
}
