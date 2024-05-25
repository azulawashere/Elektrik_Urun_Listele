using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektrik_Urun_Listele.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ModelNo { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Price   { get; set; }
        public int BoxCount { get; set; }
        public string Brand { get; set; }
    }
}
