using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using şakir_acar_030423006_libraryProject.Controllers;
using businessLayer.abstracts;
using dataAccessLayer;

namespace şakir_acar_030423006_libraryProject.Controllers
{
    public class OduncVerilenKitaplarController : Controller
    {
        private readonly IOduncServis _oduncServis;
        private readonly IUyelerService _uyelerServis;
        private readonly Context _context;

        public OduncVerilenKitaplarController(
            IOduncServis oduncServis,
            IUyelerService uyelerServis,
            Context context)
        {
            _oduncServis = oduncServis;
            _uyelerServis = uyelerServis;
            _context = context;
        }

        public IActionResult Index()
        {
            // _context ile DB işlemleri burada yapılabilir
            return View();
        }
    }
}
