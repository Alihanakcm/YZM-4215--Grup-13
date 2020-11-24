using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_MemberManager : ITbl_MemberService
    {
        private ITbl_MemberDal _Tbl_MemberDal;

        public Tbl_MemberManager(ITbl_MemberDal Tbl_MemberDal)
        {
            _Tbl_MemberDal = Tbl_MemberDal;
        }
        public void Add(Tbl_Member Parameter)
        {
            _Tbl_MemberDal.Add(Parameter);
        }

        public void Delete(Tbl_Member Parameter)
        {
            _Tbl_MemberDal.Delete(Parameter);
        }

        public Tbl_Member Get(int Parameter)
        {
            return _Tbl_MemberDal.Get(x => x.MemberID == Parameter);
        }

        public List<Tbl_Member> GetAll()
        {
            return _Tbl_MemberDal.GetList();
        }

        public void Update(Tbl_Member Parameter)
        {
            _Tbl_MemberDal.Update(Parameter);
        }

        public Tbl_Member LoginControlGet(int IDNumberr, string MemberPasswordd)
        {
            return _Tbl_MemberDal.Get(x => x.IDNumber == IDNumberr && x.MemberPassword == MemberPasswordd);

        }
    }
}
