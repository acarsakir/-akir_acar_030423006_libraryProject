using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace businessLayer.abstracts
{
    public interface IKitaplarService
    {
        void insert(kitaplar p);
        void update(kitaplar p);
        void delete(kitaplar p);
        List<kitaplar> getAll();
        kitaplar getById(int Id);

        List<kitaplar> List(Expression<Func<kitaplar, bool>> filter);
    }
}
