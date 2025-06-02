using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace businessLayer.abstracts
{
    public interface IUyelerService
    {
        void insert(uyeler p);
        void update(uyeler p);
        void delete(uyeler p);
        List<uyeler> getAll();
        uyeler getById(int Id);

        List<uyeler> List(Expression<Func<uyeler, bool>> filter);
    }
}
