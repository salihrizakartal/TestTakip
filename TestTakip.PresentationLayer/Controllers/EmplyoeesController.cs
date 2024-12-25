using Microsoft.AspNetCore.Mvc;
using TestTakip.BusinessLayer.Abstract;
using TestTakip.EntityLayer.Concrete;

namespace TestTakip.PresentationLayer.Controllers
{
    public class EmplyoeesController : Controller
    {
        private readonly IEmplyoeeService _emplyoeeService;

        public EmplyoeesController(IEmplyoeeService emplyoeeService)
        {
            _emplyoeeService = emplyoeeService;
        }

        //Personel Listeleme

        //Vibrasyon
        public IActionResult VibrasyonList()
        {
            
            var values = _emplyoeeService.TGetAll();

     
            return View(values);


        }

        //TMK
        public IActionResult TMKList()
        {

            var values = _emplyoeeService.TGetAll();


            return View(values);


        }

        //Korozyon
        public IActionResult KorozyonList()
        {

            var values = _emplyoeeService.TGetAll();


            return View(values);


        }

        //Personel Ekleme

        //Vibrasyon

        [HttpGet]

        public IActionResult CreateVibrasyonEmplyoee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVibrasyonEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TInsert(emplyoee);
            return RedirectToAction("VibrasyonList");
        }

        //TMK
        [HttpGet]

        public IActionResult CreateTMKEmplyoee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTMKEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TInsert(emplyoee);
            return RedirectToAction("TMKList");
        }

        //Korozyon
        [HttpGet]

        public IActionResult CreateKorozyonEmplyoee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateKorozyonEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TInsert(emplyoee);
            return RedirectToAction("KorozyonList");
        }


        //Personel Silme

        //Vibrasyon
        public IActionResult DeleteVibrasyonEmplyoee(int id)
        {
            _emplyoeeService.TDelete(id);
            return RedirectToAction("VibrasyonList");
        }

        //TMK

        public IActionResult DeleteTMKEmplyoee(int id)
        {
            _emplyoeeService.TDelete(id);
            return RedirectToAction("TMKList");
        }

        //Korozyon

        public IActionResult DeleteKorozyonEmplyoee(int id)
        {
            _emplyoeeService.TDelete(id);
            return RedirectToAction("KorozyonList");
        }
        //Personel Güncelleme

        //Vibrasyon

        [HttpGet]
        public IActionResult UpdateVibrasyonEmplyoee(int id)
        {
            var value = _emplyoeeService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateVibrasyonEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TUpdate(emplyoee);
            return RedirectToAction("VibrasyonList");
        }

        //TMK

        [HttpGet]
        public IActionResult UpdateTMKEmplyoee(int id)
        {
            var value = _emplyoeeService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTMKEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TUpdate(emplyoee);
            return RedirectToAction("TMKList");
        }

        //Korozyon

        [HttpGet]
        public IActionResult UpdateKorozyonEmplyoee(int id)
        {
            var value = _emplyoeeService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateKorozyonEmplyoee(Emplyoee emplyoee)
        {
            _emplyoeeService.TUpdate(emplyoee);
            return RedirectToAction("KorozyonList");
        }

    }
}
