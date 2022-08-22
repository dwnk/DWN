using dwn.Domain.Interfaces;
using dwn.Service;
using dwn.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwn.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AdicionarDependencias(this IServiceCollection services)
        {
            services.AddScoped<ITradeService, TradeService>();
            return services;
        }
    }
}
