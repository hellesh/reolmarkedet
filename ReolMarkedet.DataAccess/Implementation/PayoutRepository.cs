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
    public class PayoutRepository : GenericRepository<Payout>, IPayoutRepository
    {
        public PayoutRepository(ReolMarkedetDbContext context) : base(context)
        {
            
        }
    }
}
