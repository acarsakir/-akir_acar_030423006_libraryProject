using businessLayer.abstracts;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

public class kitaplarController : Controller
{
    private readonly IKitaplarService _kitaplarService;

    public kitaplarController(IKitaplarService kitaplarService)
    {
        _kitaplarService = kitaplarService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var values = _kitaplarService.getAll();
        return View(values);
    }

    [HttpGet] // Sayfa açıldığında çağrılır
    public IActionResult ekleKitap()
    {
        return View();
    }

    [HttpPost] // Form post edildiğinde çağrılır
    public IActionResult ekleKitap(kitaplar p)
    {
      
            _kitaplarService.insert(p);
            return RedirectToAction("Index");
        
        
    }
    [HttpGet]
    public IActionResult düzenleKitap(int id)
    {
        var kitap = _kitaplarService.getById(id);
        return View(kitap);
    }
    [HttpPost]
    public IActionResult düzenleKitap(kitaplar p)
    {
        _kitaplarService.update(p);
        return RedirectToAction("Index");
    }
    public IActionResult silKitap(int id)
    {
        var value = _kitaplarService.getById(id);
        _kitaplarService.delete(value);
        return RedirectToAction("Index");
    }
}
