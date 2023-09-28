using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain.Entities
{
    public class Sale
    { 
        [Key]
        public int saleId { get; set; }
        public double price { get; set; }
        public double discountInPercentage { get; set; }
        public double priceOfSale { get; set; }
        public int barcodeInNumbers { get; set; }
        public List<Barcode>? Barcodes { get; set; }
    }
}
