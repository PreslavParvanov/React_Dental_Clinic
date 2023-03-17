using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DentalClinic.BL.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Service
{
    public class CloudinaryService : ICloudinaryService
    {
        const string CloudinaryKey = "287841424234317";
        const string CloudinarySecret = "AHPTX1_c47FmOARrQvTo74pfTEs";
        const string CloudinaryName = "ddfrnob2x";

        Account account = new Account(CloudinaryName, CloudinaryKey, CloudinarySecret);

        public async Task<string> UploadImage(string filePath)
        {
            Cloudinary _cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath)
            };
            var uploadResult = _cloudinary.Upload(uploadParams);

            return uploadResult.Uri.ToString(); 
        }
    }
}
