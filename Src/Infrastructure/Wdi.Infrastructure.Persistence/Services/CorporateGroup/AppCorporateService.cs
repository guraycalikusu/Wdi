using System.Linq.Expressions;
using Wdi.Core.Application.DTO.Common;
using Wdi.Core.Application.DTO.CorporateGroup.Corporate;
using Wdi.Core.Application.DTO.Request;
using Wdi.Core.Application.Interfaces.Common;
using Wdi.Core.Application.Interfaces.Services.CorporateGroup;
using Wdi.Core.Domain.Entities.Tables.CorporateGroup;

namespace Wdi.Infrastructure.Persistence.Services.CorporateGroup
{
    /// <summary>
    /// Kurumsal Servisi
    /// </summary>
    public partial class AppCorporateService : IAppCorporateService
    {
        private readonly IUnitOfWork work;
        public AppCorporateService(IUnitOfWork work)
        {
            this.work = work;
        }
        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Kurumsal Servisi
    /// </summary>
    public partial class AppCorporateService : IAppCorporateService
    {
        public Task<AppResult<AppDummy, ListCorporate, AppError>> AppCatalogAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<AppDummy, ListCorporate, AppError>> AppCatalogAsync(Expression<Func<Corporate, bool>> include)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<AppDummy, ListCorporate, AppError>> AppCatalogAsync<Selected, TSource>(Expression<Func<Corporate, bool>> include, Expression<Func<Corporate, Selected>> selected, Expression<Func<Corporate, TSource>> source, RequestParameters request)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<GetCorporate, AppDummy, AppError>> AppExchangeAsync(UpdateCorporate model)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<GetCorporate, AppDummy, AppError>> AppInsertAsync(SaveCorporate model)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<GetCorporate, AppDummy, AppError>> AppReadAsync(Expression<Func<Corporate, bool>> include)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<GetCorporate, AppDummy, AppError>> AppReadAsync<Selected, TSource>(Expression<Func<Corporate, bool>> include, Expression<Func<Corporate, Selected>> selected, Expression<Func<Corporate, TSource>> source, bool ascending)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AppStoreAsync(Expression<Func<Corporate, bool>> include)
        {
            throw new NotImplementedException();
        }

        public Task<AppResult<AppDummy, AppDeleteReport<int>, AppError>> AppTerminateAsync(IList<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<int> AppTotalAsync(Expression<Func<Corporate, bool>> include)
        {
            throw new NotImplementedException();
        }
    }
}
