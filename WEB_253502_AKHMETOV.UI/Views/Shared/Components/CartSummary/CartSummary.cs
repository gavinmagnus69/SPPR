using Microsoft.AspNetCore.Mvc;

namespace WEB_253502_AKHMETOV.UI.Views.Shared.Components.CartSummary
{
    public class CartSummary : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
