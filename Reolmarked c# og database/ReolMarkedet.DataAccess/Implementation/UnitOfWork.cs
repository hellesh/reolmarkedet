using ReolMarkedet.DataAccess.Context;
using ReolMarkedet.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ReolMarkedetDbContext _context;

        public UnitOfWork(ReolMarkedetDbContext context)
        {
            _context = context;
            Barcode = new BarcodeRepository(_context);
            Payout = new PayoutRepository(_context);
            ShelfTenant = new ShelfTenantRepository(_context);
            Sale = new SaleRepository(_context);
        }

        public IBarcodeRepository Barcode { get; private set; }
        public IPayoutRepository Payout { get; private set; }
        public ISaleRepository Sale { get; private set; }
        public IShelfTenantRepository ShelfTenant { get; private set; }


        public int Save()
        {
            return _context.SaveChanges();

        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
