using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using businessLayer.abstracts;
using dataAccessLayer.abstracts;
using entityLayer.concrete;

namespace businessLayer.concrete
{
    public class appUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public appUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void delete(appUser p)
        {
            _appUserDal.delete(p);
        }

        public List<appUser> getAll()
        {
            return _appUserDal.getAll();
        }

        public appUser getById(int Id)
        {
            return _appUserDal.getById(Id);
        }

        public void insert(appUser p)
        {
            _appUserDal.insert(p);
        }

        public List<appUser> List(Expression<Func<appUser, bool>> filter)
        {
            return _appUserDal.List(filter);
        }

        public void update(appUser p)
        {
            _appUserDal.update(p);
        }
    }
}
