namespace ShoppingCartWeb.Areas.Customers.Models.ViewModel
{
    public class NotificationVM
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string? NotificationType { get; set; }
        public bool IsVisible { get; set; }
    }
}
