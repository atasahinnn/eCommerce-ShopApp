using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity
{
    public class Order
    {

        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        public EnumPaymentTypes PaymentType { get; set; }
        public EnumOrderState OrderState { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }

    public enum EnumPaymentTypes
    {
        CreditCard = 0,
        EFT = 1
    }
    public enum EnumOrderState
    {
        waiting = 0,
        unpaid = 1,
        completed = 2            
    }
}
