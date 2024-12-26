using Microsoft.AspNetCore.Mvc;
using TestTakip.BusinessLayer.Abstract;
using TestTakip.EntityLayer.Concrete;
using X.PagedList;
using X.PagedList.Extensions;

namespace TestTakip.PresentationLayer.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        //Görev Listeleme

        //Vibrasyon
        public IActionResult VibrasyonJobList(int page=1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }

        //TMK

        public IActionResult TMKJobList(int page = 1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }

        //Korozyon
        public IActionResult KorozyonJobList(int page = 1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }

        //Görev Ekleme

        //Vibrasyon

        [HttpGet]

        public IActionResult CreateVibrasyonJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVibrasyonJob(Job job)
        {
            _jobService.TInsert(job);

            return RedirectToAction("VibrasyonJobList");
        }

        //TMK

        [HttpGet]

        public IActionResult CreateTMKJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTMKJob(Job job)
        {
            _jobService.TInsert(job);

            return RedirectToAction("TMKJobList");
        }


        //Korozyon

        [HttpGet]

        public IActionResult CreateKorozyonJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateKorozyonJob(Job job)
        {
            _jobService.TInsert(job);

            return RedirectToAction("KorozyonJobList");
        }
    }
}
