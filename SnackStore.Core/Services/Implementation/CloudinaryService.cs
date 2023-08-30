using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SnackStore.Core.Services.Interface;
using System.Security.Principal;

namespace SnackStore.Core.Services.Implementation
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration configuration)
        {
            Account cloudinaryAccount = new Account(
                configuration["Cloudinary:CloudName"],
                configuration["Cloudinary:ApiKey"],
                configuration["Cloudinary:ApiSecret"]);

            _cloudinary = new Cloudinary(cloudinaryAccount);
        }

        public async Task<string> UploadImage(IFormFile imageFile)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(imageFile.FileName, imageFile.OpenReadStream())
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            return uploadResult.SecureUrl.AbsoluteUri;
        }

        public async Task<bool> DeleteImage(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);

            var deleteResult = await _cloudinary.DestroyAsync(deleteParams);

            return deleteResult.Result == "ok";
        }
    }
}
