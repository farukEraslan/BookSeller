﻿namespace BookSeller.Business.DependencyInjections
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            return services;
        }
    }
}
