using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_CategoryManager : ITbl_CategoryService
    {
        private ITbl_CategoryDal _Tbl_CategoryDal;

        public Tbl_CategoryManager(ITbl_CategoryDal Tbl_CategoryDal)
        {
            _Tbl_CategoryDal = Tbl_CategoryDal;
        }
        public void Add(Tbl_Category Parameter)
        {
            _Tbl_CategoryDal.Add(Parameter);
        }

        public void Delete(Tbl_Category Parameter)
        {
            _Tbl_CategoryDal.Delete(Parameter);
        }

        public Tbl_Category Get(int Parameter)
        {
            return _Tbl_CategoryDal.Get(x => x.CategoryID == Parameter);
        }

        public List<Tbl_Category> GetAll()
        {
            return _Tbl_CategoryDal.GetList();
        }

        public void Update(Tbl_Category Parameter)
        {
            _Tbl_CategoryDal.Update(Parameter);
        }
    }
}
