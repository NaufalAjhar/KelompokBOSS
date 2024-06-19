using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAPP.UlasanProduct
{
    public class Review
    {
        public string Username { get; set; }
        public string ReviewSentiment { get; set; }
        public string ReviewContent { get; set; }
        public int ProductId { get; set; }
    }

}
