using Microsoft.AspNetCore.Mvc;
using TestTakip.BusinessLayer.Abstract;
using TestTakip.EntityLayer.Concrete;

namespace TestTakip.PresentationLayer.Controllers
{
    public class TestPlansController : Controller
    {
        private readonly ITestPlanService _testPlanService;

        public TestPlansController(ITestPlanService testPlanService)
        {
            _testPlanService = testPlanService;
        }

        //Personel Listeleme

        //Vibrasyon
        public IActionResult VibrasyonPlanList()
        {

            var values = _testPlanService.TGetAll();


            return View(values);


        }

        //TMK
        public IActionResult TMKPlanList()
        {

            var values = _testPlanService.TGetAll();


            return View(values);


        }

        //Korozyon
        public IActionResult KorozyonPlanList()
        {

            var values = _testPlanService.TGetAll();


            return View(values);


        }

        //Yönetici
        public IActionResult TestPlanList()
        {

            var values = _testPlanService.TGetAll();


            return View(values);


        }

        //Dışa Aktar
        public IActionResult TestPlanExport()
        {

            var values = _testPlanService.TGetAll();


            return View(values);


        }



    }
}
