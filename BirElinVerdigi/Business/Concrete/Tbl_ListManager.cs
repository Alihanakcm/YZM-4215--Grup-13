using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_ListManager : ITbl_ListService
    {
        private ITbl_ListDal _Tbl_ListDal;

        public Tbl_ListManager(ITbl_ListDal Tbl_ListDal)
        {
            _Tbl_ListDal = Tbl_ListDal;
        }
        public void Add(Tbl_List Parameter)
        {
            _Tbl_ListDal.Add(Parameter);
        }

        public void Delete(Tbl_List Parameter)
        {
            _Tbl_ListDal.Delete(Parameter);
        }

        public Tbl_List Get(int Parameter)
        {
            return _Tbl_ListDal.Get(x => x.ListID == Parameter);
        }

        public List<Tbl_List> GetAll()
        {
            return _Tbl_ListDal.GetList();
        }

        public void Update(Tbl_List Parameter)
        {
            _Tbl_ListDal.Update(Parameter);
        }
    }
}
