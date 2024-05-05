using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    [Table("t_order_details")]
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        [Column("id"), Key]
        public int Id { get; set; }
        [ForeignKey("order_id")]
        public Order Order { get; set; }
        [ForeignKey("stuff_id")]
        public Stuff Stuff { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("qty")]
        public int Qty { get; set; }

        public OrderDetail(Order order, Stuff stuff, int price, int qty)
        {
            Order = order;
            Stuff = stuff;
            Price = price;
            Qty = qty;
        }
    }
}
