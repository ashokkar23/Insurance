using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PremiumCalculator.Application.Mappers;
using PremiumCalculator.Application.Repositories;
using PremiumCalculator.Application.Services.Implementations;
using PremiumCalculator.Application.Services.Abstractions;
using PremiumCalculator.Infrastructure.Persistance;
using PremiumCalculator.Infrastructure.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Register infrastructure services here
            services.AddDbContext<PremiumCalculatorDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DbConnection");
                options.UseSqlServer(connectionString);
            });

            //Register Repositories
            services.AddScoped<IPremiumCalculatorRepository, PremiumCalculatorRepository>();
            services.AddScoped<IOccupationRepository, OccupationRepository>();

            //Register other infrastructure services as needed
            services.AddScoped<IPremiumCalculatorService, PremiumCalculatorService>();
            

            services.AddAutoMapper(cfg => cfg.AddProfile<MemberMappers>());
            services.AddAutoMapper(cfg => cfg.AddProfile<OccupationMappers>());
        }
    }

    
}