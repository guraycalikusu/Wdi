using Microsoft.Extensions.DependencyInjection;
using Wdi.Core.Application.Interfaces.Common;
using Wdi.Core.Application.Interfaces.Repositories.CorporateGroup;
using Wdi.Infrastructure.Persistence.Repositories.Common;
using Wdi.Infrastructure.Persistence.Repositories.CorporateGroup;

namespace Wdi.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServiceRegistration(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ICorporateRepository, CorporateRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
