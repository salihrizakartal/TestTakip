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
        public IActionResult VibrasyonJobList(int page=1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }

      

        public IActionResult TMKJobList(int page = 1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }
        public IActionResult KorozyonJobList(int page = 1)
        {

            var values = _jobService.TGetAll();


            return View(values.ToPagedList(page,20));


        }
    }
}
