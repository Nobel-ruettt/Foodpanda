using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace FoodPandaApi.Cloudinary
{
    public class CloudinaryServices : ICloudinaryServices
    {
        private readonly CloudinaryDotNet.Cloudinary _cloudinary;

        public CloudinaryServices(IOptions<CloudinarySettings> cloudinaryConfigOptions)
        {
            Account acc = new Account(
                cloudinaryConfigOptions.Value.CloudName,
                cloudinaryConfigOptions.Value.ApiKey,
                cloudinaryConfigOptions.Value.ApiSecret
            );
            _cloudinary = new CloudinaryDotNet.Cloudinary(acc);
        }

        public ImageUploadResult UploadFile(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();
            using (var stream = file.OpenReadStream())
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.Name, stream)
                };
                uploadResult = _cloudinary.Upload(uploadParams);
            }
            return uploadResult;
        }
    }
}
