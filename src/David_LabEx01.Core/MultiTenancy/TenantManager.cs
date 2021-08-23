using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using David_LabEx01.Authorization.Users;
using David_LabEx01.Editions;

namespace David_LabEx01.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
