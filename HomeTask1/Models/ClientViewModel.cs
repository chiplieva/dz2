using HomeTask1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Fio_Id { get; set; }

        public string FisrtName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public static ClientViewModel FormDB(Client context)
        {
            var client = new ClientViewModel();
            client.Id = context.Id;
            client.OrderId = context.OrderId;
            client.Fio_Id = context.Fio_Id;
            client.FisrtName = context.fio.FirstName;
            client.MiddleName = context.fio.MiddleName;
            client.LastName = context.fio.LastName;

            return client;
        }
    }
}
