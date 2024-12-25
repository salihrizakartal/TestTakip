using Microsoft.AspNetCore.Mvc;

namespace TestTakip.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptsLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
