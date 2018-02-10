using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OrchardCore.IdGeneration.Scripting;
using OrchardCore.Scripting;

namespace OrchardCore.IdGeneration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdGeneration(this IServiceCollection services)
        {
            services.TryAddSingleton<IIdGenerator, DefaultIdGenerator>();
            services.TryAddSingleton<IGlobalMethodProvider, IdGeneratorMethod>();
            return services;
        }
    }
}