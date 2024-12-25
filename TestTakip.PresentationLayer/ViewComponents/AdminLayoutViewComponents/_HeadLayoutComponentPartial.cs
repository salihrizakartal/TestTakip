using Microsoft.AspNetCore.Mvc;

namespace TestTakip.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
