using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain.Entities
{
    public class Payout
    {
        [Key]
        public int payoutId { get; set; }
        public double fine { get; set; }
        public double commission { get; set; }
        public double totalPayout { get; set; }
        public double totalSale { get; set; }
        public double commissionDeduction { get; set; }
        [ForeignKey("ShelfTenant")]
        public int ShelfTenanttenantId { get; set; }
        public ShelfTenant? ShelfTenant { get; set; }
    }
}
