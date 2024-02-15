namespace RestaurauntApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserName { get; set; }
      //  public int CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public EnumOrderState OrderState { get; set; }
       // public virtual User Customer { get; set; } // Навигационное свойство к пользователю, который разместил заказ
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public Order()
        {
            OrderItems = new List<OrderItem>();
            CreatedAt = DateTime.Now;
            TotalPrice = 0;
            OrderState = EnumOrderState.waiting;
        }
    }

    public enum EnumOrderState
    {
        waiting = 0,
        unpaid = 1,
        completed = 2
    }
}