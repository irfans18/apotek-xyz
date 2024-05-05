using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    [Table("t_orders")]
    public class Order
    {
        public Order()
        {
        }

        [Column("id"), Key]
        public int Id { get; set; }
        [Column("faktur_no")]
        public string FakturNo { get; set; }
        [Column("faktur_date")]
        public DateTime Date { get; set;}

        public ICollection<OrderDetail> Details { get; set; }

        public Order(string fakturNo, DateTime date)
        {
            FakturNo = fakturNo;
            Date = date;
        }
    }
}
