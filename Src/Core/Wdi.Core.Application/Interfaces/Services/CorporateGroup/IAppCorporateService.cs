using Wdi.Core.Application.DTO.Common;
using Wdi.Core.Application.DTO.CorporateGroup.Corporate;
using Wdi.Core.Application.Interfaces.Common;
using Wdi.Core.Domain.Entities.Tables.CorporateGroup;

namespace Wdi.Core.Application.Interfaces.Services.CorporateGroup
{
    /// <summary>
    /// Kurumsal Servis Ara Yüzü
    /// </summary>
    public interface IAppCorporateService : IAppService<Corporate, SaveCorporate, UpdateCorporate, GetCorporate, ListCorporate, ListCorporate, AppError, AppDeleteReport<int>, int>
    {

    }
}
