using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SnackStore.Core.Services.Interface
{
    public interface ICloudinaryService
    {
        Task<string> UploadImage(IFormFile imageFile);
        Task<bool> DeleteImage(string publicId);
    }
}
