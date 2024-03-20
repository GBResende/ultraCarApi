using UltracarAPI.Repositories;
using UltracarAPI.Repositories.Interfaces;
using UltracarAPI.Services;
using UltracarAPI.Services.Interfaces;

namespace UltracarAPI.Utils.Ioc
{
    public static class DependencesInjections
    {
        public static void CreateDependecesInjections(this IServiceCollection service)
        {
            //injeção dos repositórios
            service.AddScoped<IBudgetRepository, BudgetRepository>();
            //service.AddScoped<IPartRepository, PartRepository>();
            //service.AddScoped<IStockMovementRepository, StockMovementRepository>();

            //injeção dos services
            service.AddScoped<IBudgetService, BudgetService>();
            //service.AddScoped<IPartService, PartService>();
            //service.AddScoped<IStockMovementService, StockMovementService>();

            //injeção dos useCases

        }
    }
}
