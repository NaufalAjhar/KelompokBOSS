using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAPP
{
    public class purchasedItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int qty { get; set; }
        public int Price { get; set; }
        public int UserId { get; set; }
    }
}
