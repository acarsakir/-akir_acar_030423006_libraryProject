using businessLayer.abstracts;
using dataAccessLayer;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace şakir_acar_030423006_libraryProject.Controllers
{
    public class OduncVerilenKitaplarController : Controller
    {
        private readonly IOduncServis _oduncServis;
        private readonly IUyelerService _uyelerServis;
        Context c = new Context();

        public OduncVerilenKitaplarController(IOduncServis oduncServis , IUyelerService uyelerServis)
        {
            _oduncServis = oduncServis;
            _uyelerServis = uyelerServis;
        }

        public IActionResult Index()
        {
            var values = _oduncServis.GetAllWithKitapAndUye();
            return View(values);
        }
        [HttpGet] // Sayfa açıldığında çağrılır
        public IActionResult ekleOdunc(int Id)
        {
            List<SelectListItem> values = c.Uyelers.Select(x => new SelectListItem
            {
                Text = x.ad + " " + x.soyad,
                Value = x.id.ToString()
            }).ToList();

            ViewBag.uyeList = values;

            // Yeni ödünç nesnesi oluştur
            var odunc = new odüncVerilenKitaplar
            {
                kitapId = Id // View'da doğrudan kitapId kullanılacak
            };

            return View(odunc);
        }

        [HttpPost] // Form post edildiğinde çağrılır
        public IActionResult ekleOdunc(odüncVerilenKitaplar p)
        {

            _oduncServis.insert(p);
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult düzenleOduncKitaplar(int id)
        {
            var odunc = _oduncServis.getById(id);

            var uyeList = _uyelerServis.getAll().Select(x => new SelectListItem
            {
                Text = x.ad + " " + x.soyad,
                Value = x.id.ToString(),
                Selected = (x.id == odunc.uyeId)
            }).ToList();

            ViewBag.uyeList = uyeList;

            return View(odunc);
        }

        [HttpPost]
        public IActionResult düzenleOduncKitaplar(odüncVerilenKitaplar p)
        {
            _oduncServis.update(p);
            return RedirectToAction("Index");
        }
        public IActionResult silKitap(int id)
        {
            var value = _oduncServis.getById(id);
            _oduncServis.delete(value);
            return RedirectToAction("Index");
        }
    }
}
