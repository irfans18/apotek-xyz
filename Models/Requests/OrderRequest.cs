using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models.Requests
{
    public class OrderRequest
    {
        public OrderRequest(DateTime dateTime, List<OrderItemsRequest> items)
        {
            DateTime = dateTime;
            Items = items;
        }

        public OrderRequest()
        {
        }

        public DateTime DateTime { get; set; }
        public List<OrderItemsRequest> Items { get; set; }

    }
}
