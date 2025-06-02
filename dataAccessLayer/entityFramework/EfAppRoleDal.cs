using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataAccessLayer.abstracts;
using dataAccessLayer.concrete.repositories;
using entityLayer.concrete;

namespace dataAccessLayer.entityFramework
{
    public class EfAppRoleDal : genericRepository<appRole>, IAppRoleDal
    {
        public EfAppRoleDal(Context context) : base(context)
        {
        }
    }
}
