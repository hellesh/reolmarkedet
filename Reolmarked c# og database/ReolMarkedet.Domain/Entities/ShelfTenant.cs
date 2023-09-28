using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain.Entities
{
    public class ShelfTenant
    {
        [Key]
        public int tenantId { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public double totalSale { get; set; }
        public string bankAccountDetails { get; set; } = string.Empty;
        // static count ??
        public List<Payout>? Payouts { get; set; }
        public List<Barcode>? Barcodes { get; set; }
    }
}
