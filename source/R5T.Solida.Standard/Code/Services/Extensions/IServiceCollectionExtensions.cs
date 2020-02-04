using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Solida.Solutas;
using R5T.Solutas.Standard;


namespace R5T.Solida.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileSiteSerializer"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileSiteSerializer(this IServiceCollection services)
        {
            services.AddVisualStudioSolutionFileSiteSerializer(services.AddVisualStudioSolutionFileSerializerAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioSolutionFileSiteSerializer"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioSolutionFileSiteSerializer> AddVisualStudioSolutionFileSiteSerializerAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioSolutionFileSiteSerializer>(() => services.AddVisualStudioSolutionFileSiteSerializer());

            return serviceAction;
        }
    }
}
