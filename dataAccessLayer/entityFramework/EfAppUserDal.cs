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
    public class EfAppUserDal : genericRepository<appUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }
    }
}
