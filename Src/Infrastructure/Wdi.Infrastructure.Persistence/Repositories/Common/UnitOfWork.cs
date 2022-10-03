using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdi.Core.Application.Interfaces.Common;
using Wdi.Core.Application.Interfaces.Repositories.CorporateGroup;

namespace Wdi.Infrastructure.Persistence.Repositories.Common
{
    public partial class UnitOfWork : IUnitOfWork
    {
        public ICorporateRepository _corporate => throw new NotImplementedException();

        public int Check(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public Task<int> CheckAsync(CancellationToken token)
        {
            throw new NotImplementedException();
        }

        private bool _disposed = false;
        protected virtual async ValueTask DisposeAsync(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                
            }
            _disposed = true;
        }
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
    }
}
