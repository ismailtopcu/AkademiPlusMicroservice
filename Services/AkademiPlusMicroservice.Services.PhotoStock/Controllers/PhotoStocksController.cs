﻿using AkademiPlusMicroservice.Services.PhotoStock.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroservice.Services.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoStocksController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SavePhoto(IFormFile formFile, CancellationToken cancellationToken)
        {
            if(formFile != null && formFile.Length>0)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/photos",formFile.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                await formFile.CopyToAsync(stream, cancellationToken);
                var returnPath = formFile.FileName;
                PhotoDto photoDto = new PhotoDto()
                {
                    Url = returnPath
                };
                return Ok("Fotoğraf Başarıyla Kaydedildi");
            }
            return Ok("Bir Hata Oluştu");
        }
    }
}
