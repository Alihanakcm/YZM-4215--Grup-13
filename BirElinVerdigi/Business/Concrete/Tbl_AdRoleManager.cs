using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
   public class Tbl_AdRoleManager : ITbl_AdRoleService
    {
        private ITbl_AdRoleDal _Tbl_AdRoleDal;

        public Tbl_AdRoleManager(ITbl_AdRoleDal Tbl_AdRoleDal)
        {
            _Tbl_AdRoleDal = Tbl_AdRoleDal;
        }
        public void Add(Tbl_AdRole Parameter)
        {
            _Tbl_AdRoleDal.Add(Parameter);
        }

        public void Delete(Tbl_AdRole Parameter)
        {
            _Tbl_AdRoleDal.Delete(Parameter);
        }

        public Tbl_AdRole Get(int Parameter)
        {
            return _Tbl_AdRoleDal.Get(x => x.AdRoleID == Parameter);
        }

        public List<Tbl_AdRole> GetAll()
        {
            return _Tbl_AdRoleDal.GetList();
        }

        public void Update(Tbl_AdRole Parameter)
        {
            _Tbl_AdRoleDal.Update(Parameter);
        }
    }
}
