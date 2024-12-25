using Microsoft.AspNetCore.Mvc;

namespace TestTakip.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}
	}
}
