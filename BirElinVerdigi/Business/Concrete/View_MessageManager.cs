using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
  public  class View_MessageManager : IView_MessageService
    {
        private IView_MessageDal _View_MessageDal;

        public View_MessageManager(IView_MessageDal View_MessageDal)
        {
            _View_MessageDal = View_MessageDal;
        }
        public void Add(View_Message Parameter)
        {
            _View_MessageDal.Add(Parameter);
        }

        public void Delete(View_Message Parameter)
        {
            _View_MessageDal.Delete(Parameter);
        }

        public View_Message Get(int Parameter)
        {
            return _View_MessageDal.Get(x => x.CategoryID == Parameter);
        }

        public List<View_Message> GetAll()
        {
            return _View_MessageDal.GetList();
        }

        public void Update(View_Message Parameter)
        {
            _View_MessageDal.Update(Parameter);
        }
    }
}
