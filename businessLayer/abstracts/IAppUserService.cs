using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace businessLayer.abstracts
{
    public interface IAppUserService
    {
        void insert(appUser p);
        void update(appUser p);
        void delete(appUser p);
        List<appUser> getAll();
        appUser getById(int Id);

        List<appUser> List(Expression<Func<appUser, bool>> filter);
    }
}
