using Microsoft.AspNetCore.Mvc;

namespace TestTakip.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _CustomTempleteLayoutPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
