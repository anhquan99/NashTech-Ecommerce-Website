using Azure.Identity;
using Ecomerece_Web.Services;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Extension
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddStorageServices(this IServiceCollection services, IConfiguration configuration)
        {
            var azureStorageOption = configuration.GetSection("Storage").Get<AzureStorageOption>();

            services.AddAzureClients(builder =>
            {
                builder.AddBlobServiceClient(azureStorageOption.ConnectionString);
                builder.UseCredential(new EnvironmentCredential());
            });

            services.AddSingleton(azureStorageOption);

            services.AddScoped<FileService>();

            return services;
        }
    }
}
