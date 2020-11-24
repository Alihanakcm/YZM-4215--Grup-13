using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_RequestStateManager : ITbl_RequestStateService
    {
        private ITbl_RequestStateDal _Tbl_RequestStateDal;

        public Tbl_RequestStateManager(ITbl_RequestStateDal Tbl_RequestStateDal)
        {
            _Tbl_RequestStateDal = Tbl_RequestStateDal;
        }
        public void Add(Tbl_RequestState Parameter)
        {
            _Tbl_RequestStateDal.Add(Parameter);
        }

        public void Delete(Tbl_RequestState Parameter)
        {
            _Tbl_RequestStateDal.Delete(Parameter);
        }

        public Tbl_RequestState Get(int Parameter)
        {
            return _Tbl_RequestStateDal.Get(x => x.RequestStateID == Parameter);
        }

        public List<Tbl_RequestState> GetAll()
        {
            return _Tbl_RequestStateDal.GetList();
        }

        public void Update(Tbl_RequestState Parameter)
        {
            _Tbl_RequestStateDal.Update(Parameter);
        }
    }
}
