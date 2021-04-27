using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1.Models
{
    public class ManagerViewModel
    {

        public OrderViewModel SelectedModel { get; set; }

        public ObservableCollection<OrderViewModel> Orders { get; set; }

        public ManagerViewModel()
        {
            using (var context = new Entity.Magnit())
            {
                context.Order.Load();
                Orders = new ObservableCollection<OrderViewModel>(
                    from order in context.Order.Local
                    select OrderViewModel.FromDB(order));
            }
        }
    }
}
