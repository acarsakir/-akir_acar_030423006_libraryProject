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
    public class uyelerManager : IUyelerService
    {
        IUyelerDal _uyelerDal;

        public uyelerManager(IUyelerDal uyelerDal)
        {
            _uyelerDal = uyelerDal;
        }

        public void delete(uyeler p)
        {
            _uyelerDal.delete(p);
        }

        public List<uyeler> getAll()
        {
            return _uyelerDal.getAll(); 
        }

        public uyeler getById(int Id)
        {
            return _uyelerDal.getById(Id);
        }

        public void insert(uyeler p)
        {
            _uyelerDal.insert(p);
        }

        public List<uyeler> List(Expression<Func<uyeler, bool>> filter)
        {
            return _uyelerDal.List(filter);
        }

        public void update(uyeler p)
        {
            _uyelerDal.update(p);
        }
    }
}
