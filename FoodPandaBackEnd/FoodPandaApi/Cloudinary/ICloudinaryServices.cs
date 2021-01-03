using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace FoodPandaApi.Cloudinary
{
    public interface ICloudinaryServices
    {
        ImageUploadResult UploadFile(IFormFile file);
    }
}