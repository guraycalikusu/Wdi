using Wdi.Core.Application.Interfaces.Repositories.CorporateGroup;
using Wdi.Core.Domain.Entities.Tables.CorporateGroup;
using Wdi.Infrastructure.Persistence.Context;
using Wdi.Infrastructure.Persistence.Repositories.Concrete.Common;

namespace Wdi.Infrastructure.Persistence.Repositories.CorporateGroup
{
    /// <summary>
    /// Kurumsal Depo Sınıfı
    /// </summary>
    public class CorporateRepository : GenericRepository<Corporate, int>, ICorporateRepository
    {
        public CorporateRepository(WdiContext _context) : base(_context)
        {

        }
    }
}
