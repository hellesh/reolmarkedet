using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBarcodeRepository Barcode { get; }
        IPayoutRepository Payout { get; }
        ISaleRepository Sale { get; }
        IShelfTenantRepository ShelfTenant { get; }

        int Save();
    }
}
