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
    public class kitaplarManager : IKitaplarService
    {
        IKitaplarDal _kitaplarDal;

        public kitaplarManager(IKitaplarDal kitaplarDal)
        {
            _kitaplarDal = kitaplarDal;
        }

        public void delete(kitaplar p)
        {
            _kitaplarDal.delete(p);
        }

        public List<kitaplar> getAll()
        {
           return _kitaplarDal.getAll();
        }

        public kitaplar getById(int Id)
        {
           return _kitaplarDal.getById(Id);
        }

        public void insert(kitaplar p)
        {
            _kitaplarDal.insert(p);
        }

        public List<kitaplar> List(Expression<Func<kitaplar, bool>> filter)
        {
            return _kitaplarDal.List(filter);
        }

        public void update(kitaplar p)
        {
            _kitaplarDal.update(p);
        }
    }
}
