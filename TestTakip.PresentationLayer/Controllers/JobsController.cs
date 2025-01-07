using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //Yönetici
        public IActionResult JobList()
        {

            var values = _jobService.TGetAll();


            return View(values);


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


        //Yönetici

        [HttpGet]

        public IActionResult CreateJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateJob(Job job)
        {
            _jobService.TInsert(job);

            return RedirectToAction("JobList");
        }

        //Görev Silme

        //Vibrasyon
        public IActionResult DeleteVibrasyonJob(int id)
        {
            _jobService.TDelete(id);
            return RedirectToAction("VibrasyonJobList");
        }

        //TMK
        public IActionResult DeleteTMKJob(int id)
        {
            _jobService.TDelete(id);
            return RedirectToAction("TMKJobList");
        }

        //Korozyon
        public IActionResult DeleteKorozyonJob(int id)
        {
            _jobService.TDelete(id);
            return RedirectToAction("KorozyonJobList");
        }

        //Yönetici
        public IActionResult DeleteJob(int id)
        {
            _jobService.TDelete(id);
            return RedirectToAction("JobList");
        }

        //Görev Güncelleme

        //Vibrasyon

        [HttpGet]
        public IActionResult UpdateVibrasyonJob(int id)
        {

            var values = _jobService.TGetAll();
            ViewBag.jobs = new SelectList(values, "JobId", "EmplyoeeName");
            var jobValues = _jobService.TGetById(id);
            return View(jobValues);
        }
        [HttpPost]
        public IActionResult UpdateVibrasyonJob(Job job)
        {
            _jobService.TUpdate(job);
            return RedirectToAction("VibrasyonJobList");
        }

        //TMK

        [HttpGet]
        public IActionResult UpdateTMKJob(int id)
        {
            var values = _jobService.TGetAll();
            ViewBag.jobs = new SelectList(values, "JobId", "EmplyoeeName");
            var jobValues = _jobService.TGetById(id);
            return View(jobValues);
        }

        [HttpPost]

        public IActionResult UpdateTMKJob(Job job)
        {
            _jobService.TUpdate(job);
            return RedirectToAction("TMKJobList");
        }
        //Korozyon

        [HttpGet]
        public IActionResult UpdateKorozyonJob(int id)
        {
            var values = _jobService.TGetAll();
            ViewBag.jobs = new SelectList(values, "JobId", "EmplyoeeName");
            var jobValues = _jobService.TGetById(id);
            return View(jobValues);
        }

        [HttpPost]

        public IActionResult UpdateKorozyonJob(Job job)
        {
            _jobService.TUpdate(job);
            return RedirectToAction("KorozyonJobList");
        }

        //Yönetici

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var values = _jobService.TGetAll();
            ViewBag.jobs = new SelectList(values, "JobId", "EmplyoeeName");
            var jobValues = _jobService.TGetById(id);
            return View(jobValues);
        }

        [HttpPost]

        public IActionResult UpdateJob(Job job)
        {
            _jobService.TUpdate(job);
            return RedirectToAction("JobList");
        }


    }
}
