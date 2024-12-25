using Microsoft.AspNetCore.Mvc;

namespace TestTakip.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}
	}
}
