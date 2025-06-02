using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataAccessLayer.abstracts;
using dataAccessLayer.concrete.repositories;
using entityLayer.concrete;
using Microsoft.EntityFrameworkCore;

namespace dataAccessLayer.entityFramework
{
    public class EfOduncKitaplarDal : genericRepository<odüncVerilenKitaplar>, IOduncDal
    {
        private readonly Context _context;
        public EfOduncKitaplarDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<odüncVerilenKitaplar> GetAllWithKitapAndUye()
        {
            return _context.Odüncs
                .Include(x => x.Kitaps)
                .Include(x => x.uyelers)
                .ToList();
        }
    }
}
