using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain.Entities
{
    public class Barcode
    {
        [Key]// This indicates that barcodeInNumbers is the primary key
        public int barcodeInNumbers { get; set; }
        public double discountInPercentage { get; set; }
        [ForeignKey("ShelfTenant")]// This specifies the foreign key relationship
        public int ShelfTenanttenantId { get; set; }
        public List<Sale>? Sales { get; set; }
        public ShelfTenant? ShelfTenant { get; set; }
    }
}
