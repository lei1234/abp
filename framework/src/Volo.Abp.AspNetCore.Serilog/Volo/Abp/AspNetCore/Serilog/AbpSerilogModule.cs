using Volo.Abp.AspNetCore;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace Volo.Abp.AspNetCore.Serilog
{
    [DependsOn(
        typeof(AbpMultiTenancyModule),
        typeof(AbpAspNetCoreModule)
    )]
    public class AbpSerilogModule : AbpModule
    {
    }
}