using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    [Table("m_stuffs")]
    public class Stuff
    {

        [Column("id"), Key]
        public string Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("price")]
        public int Price {  get; set; }

        public Stuff(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Stuff()
        {
        }
    }
}
