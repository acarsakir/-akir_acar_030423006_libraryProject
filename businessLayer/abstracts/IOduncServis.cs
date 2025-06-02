using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace businessLayer.abstracts
{
    public interface IOduncServis
    {
        void insert(odüncVerilenKitaplar p);
        void update(odüncVerilenKitaplar p);
        void delete(odüncVerilenKitaplar p);
        List<odüncVerilenKitaplar> getAll();
        odüncVerilenKitaplar getById(int Id);

        List<odüncVerilenKitaplar> List(Expression<Func<odüncVerilenKitaplar, bool>> filter);
        List<odüncVerilenKitaplar> GetAllWithKitapAndUye();
    }
}
