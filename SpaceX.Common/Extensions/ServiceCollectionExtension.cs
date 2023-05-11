using Microsoft.Extensions.DependencyInjection;
using SpaceX.Services;

namespace SpaceX.Common.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IHttpClientBuilder AddLaunchApiClient(this IServiceCollection services, Action<HttpClient> configureClient)
        {
            return services.AddHttpClient<ILaunchService, LaunchService>((httpClient) =>
            {
                httpClient.AddHttpHeaders();
                configureClient(httpClient);
            });
        }
    }
}
