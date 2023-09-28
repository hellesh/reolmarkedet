using ReolMarkedet.DataAccess.Context;
using ReolMarkedet.Domain.Entities;
using ReolMarkedet.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.DataAccess.Implementation
{
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        public SaleRepository(ReolMarkedetDbContext context) : base(context)
        {
            
        }
    }
}
