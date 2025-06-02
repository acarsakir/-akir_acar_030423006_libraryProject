using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace businessLayer.abstracts
{
    public interface IAppRoleService
    {
        void insert(appRole p);
        void update(appRole p);
        void delete(appRole p);
        List<appRole> getAll();
        appRole getById(int Id);

        List<appRole> List(Expression<Func<appRole, bool>> filter);
    }
}
