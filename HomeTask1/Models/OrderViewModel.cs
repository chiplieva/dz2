using HomeTask1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string OrderName { get; set; }

        public decimal Price { get; set; }

        public ClientViewModel Client { get; set; }

        public static OrderViewModel FromDB(Order order)
        {
            var order1          = new OrderViewModel();
            order1.Id           = order.Id;
            order1.ClientId     = order.ClientId;
            order1.OrderName    = order.OrderName;
            order1.Client       = ClientViewModel.FormDB(order.Client);

            return order1;
        }
    }
}
