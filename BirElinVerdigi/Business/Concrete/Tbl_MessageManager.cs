using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class Tbl_MessageManager : ITbl_MessageService
    {
        private ITbl_MessageDal _Tbl_MessageDal;

        public Tbl_MessageManager(ITbl_MessageDal Tbl_MessageDal)
        {
            _Tbl_MessageDal = Tbl_MessageDal;
        }
        public void Add(Tbl_Message Parameter)
        {
            _Tbl_MessageDal.Add(Parameter);
        }

        public void Delete(Tbl_Message Parameter)
        {
            _Tbl_MessageDal.Delete(Parameter);
        }

        public Tbl_Message Get(int Parameter)
        {
            return _Tbl_MessageDal.Get(x => x.MessageID == Parameter);
        }

        public List<Tbl_Message> GetAll()
        {
            return _Tbl_MessageDal.GetList();
        }

        public void Update(Tbl_Message Parameter)
        {
            _Tbl_MessageDal.Update(Parameter);
        }

    }
}
