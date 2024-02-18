
using Test.Models;

namespace Middlewawre.Services
{
    public class ReserveService
    {
        public List<OrderEntity> orders { get; set; } = new List<OrderEntity>();
        public List<UserEntity> users { get; set; } = new List<UserEntity>();
        public OrderEntity Create(string title, int owner)
        {
            try
            {
                OrderEntity order = new OrderEntity()
                {
                    OwnerId = owner,
                    Title = title,
                    Id = orders.Count + 1
                };
                orders.Add(order);
                return order;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool cancelOrder(int orderId, int userId)
        {
            try
            {
                OrderEntity order = orders.FirstOrDefault(x => x.Id == orderId);
                UserEntity user = users.FirstOrDefault(x => x.Id == userId);
                if (user==null || order==null)
                {
                    return false;
                }
                if (order.OwnerId==userId || user.IsAdmin)
                {
                    orders.Remove(order);
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
