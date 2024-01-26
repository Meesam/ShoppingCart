using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Areas.Customers.Models.ViewModel;

namespace ShoppingCartWeb.Areas.Customers.Controllers
{
    [Area("Customers")]
    [Authorize]
    public class NotificationController : Controller
    {
        public IActionResult RenderNotification()
        {
            var notification1 = new NotificationVM
            {
                Id = 1,
                Message = "This is a test notification-1",
                NotificationType = "success",
                IsVisible = true
            };
            var notification2 = new NotificationVM
            {
                Id = 2,
                Message = "This is a test notification-2",
                NotificationType = "success",
                IsVisible = true
            };

            var notificationList = new List<NotificationVM>
            {
                notification1,
                notification2
            };
            return PartialView("_LoginStatePartial", notificationList);
        }
    }
}
