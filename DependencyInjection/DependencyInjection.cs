using LineInc.Service;
using Microsoft.Extensions.DependencyInjection;

namespace LineInc.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AdicionaDependencias(this IServiceCollection input)
        {
            input.AddTransient<IResultsService, ResultsService>();
            input.AddTransient<ILoginService, LoginService>();
            return input;
        }
    }
}
