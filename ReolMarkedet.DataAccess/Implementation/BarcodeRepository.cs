using ReolMarkedet.DataAccess.Context;
using ReolMarkedet.Domain.Entities;
using ReolMarkedet.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.DataAccess.Implementation
{
    public class BarcodeRepository : GenericRepository<Barcode>, IBarcodeRepository
    {
        public BarcodeRepository(ReolMarkedetDbContext context) : base(context)
        {
            
        }
    }
}
