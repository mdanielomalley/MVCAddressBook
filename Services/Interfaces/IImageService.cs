﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);

        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
