using CloudinaryDotNet;
using SnackStore.Data.Domains.Models;

namespace Snack_Store.Api.Extensions
{
    public static class CloudinaryConfiguration
    {
        public static void AddCloudinaryExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(provider =>
            {
                var cloudinarySettings = configuration.GetSection("CloudinarySettings").Get<CloudinarySettings>();
                return new Cloudinary(new Account(cloudinarySettings.CloudName, cloudinarySettings.ApiKey, cloudinarySettings.ApiSecret));
            });
        }
    }

}
