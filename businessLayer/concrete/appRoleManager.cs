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
    public class appRoleManager : IAppRoleService
    {
        IAppRoleDal _appRole;

        public appRoleManager(IAppRoleDal appRole)
        {
            _appRole = appRole;
        }

        public void delete(appRole p)
        {
            _appRole.delete(p);
        }

        public List<appRole> getAll()
        {
            return _appRole.getAll();   
        }

        public appRole getById(int Id)
        {
            return _appRole.getById(Id);
        }

        public void insert(appRole p)
        {
            _appRole.insert(p);
        }

        public List<appRole> List(Expression<Func<appRole, bool>> filter)
        {
            return _appRole.List(filter);
        }

        public void update(appRole p)
        {
            _appRole.update(p);
        }
    }
}
