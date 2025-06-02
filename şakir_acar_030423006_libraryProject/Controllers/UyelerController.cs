using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace şakir_acar_030423006_libraryProject.Controllers
{
    public class UyelerController : Controller
    {
        private readonly IUyelerService _uyelerService;

        public UyelerController(IUyelerService uyelerService)
        {
            _uyelerService = uyelerService;
        }

        public IActionResult Index()
        {
            var values = _uyelerService.getAll();
            return View(values);
        }
        [HttpGet] // Sayfa açıldığında çağrılır
        public IActionResult ekleUye()
        {
            return View();
        }

        [HttpPost] // Form post edildiğinde çağrılır
        public IActionResult ekleUye(uyeler p)
        {

            _uyelerService.insert(p);
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult düzenleUyeler(int id)
        {
            var kitap = _uyelerService.getById(id);
            return View(kitap);
        }
        [HttpPost]
        public IActionResult düzenleUyeler(uyeler p)
        {
            _uyelerService.update(p);
            return RedirectToAction("Index");
        }
        public IActionResult silUyeler(int id)
        {
            var value = _uyelerService.getById(id);
            _uyelerService.delete(value);
            return RedirectToAction("Index");
        }
    }
}
