using Microsoft.AspNetCore.Http;
using SnackStore.Data.Domains;
using SnackStore.Data.Domains.Models;

namespace SnackStore.Core.Services.Interface
{
    public interface IDocumentUploadService
    {
        Task<DocumentUploadResult> UploadFileAsync(string documentContent);
        Task<DocumentUploadResult> UploadImageAsync(IFormFile image);
        Task<bool> DeleteImage(string publicId);
    }
}
