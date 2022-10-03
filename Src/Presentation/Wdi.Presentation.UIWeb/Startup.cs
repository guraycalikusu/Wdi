using Microsoft.AspNetCore.Builder;
using Wdi.Core.Application.Interfaces.Services.CorporateGroup;
using Wdi.Infrastructure.Persistence;
using Wdi.Infrastructure.Persistence.Services.CorporateGroup;

namespace Wdi.Presentation.UIWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPersistenceServiceRegistration();
            services.AddScoped<IAppCorporateService, AppCorporateService>();
        }
    }
}
