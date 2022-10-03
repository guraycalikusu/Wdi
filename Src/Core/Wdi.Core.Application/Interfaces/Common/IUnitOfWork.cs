using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdi.Core.Application.Interfaces.Repositories.CorporateGroup;

namespace Wdi.Core.Application.Interfaces.Common
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        #region Corporate Group
        ICorporateRepository _corporate { get; }
        #endregion

        #region Save Changes
        int Check(CancellationToken token);
        Task<int> CheckAsync(CancellationToken token); 
        #endregion
    }
}
