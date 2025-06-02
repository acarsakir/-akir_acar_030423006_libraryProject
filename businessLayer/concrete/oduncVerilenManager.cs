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
    public class oduncVerilenManager : IOduncServis
    {
        IOduncDal _OduncDal;

        public oduncVerilenManager(IOduncDal oduncDal)
        {
            _OduncDal = oduncDal;
        }

        public void delete(odüncVerilenKitaplar p)
        {
            _OduncDal.delete(p);    
        }

        public List<odüncVerilenKitaplar> getAll()
        {
            return _OduncDal.getAll();  
        }

        public odüncVerilenKitaplar getById(int Id)
        {
            return _OduncDal.getById(Id);
        }

        public void insert(odüncVerilenKitaplar p)
        {
            _OduncDal.insert(p);
        }

        public List<odüncVerilenKitaplar> List(Expression<Func<odüncVerilenKitaplar, bool>> filter)
        {
            return _OduncDal.List(filter);
        }

        public void update(odüncVerilenKitaplar p)
        {
            _OduncDal.update(p);
        }
        public List<odüncVerilenKitaplar> GetAllWithKitapAndUye()
        {
            return _OduncDal.GetAllWithKitapAndUye();
        }
    }
}
