using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MundoDePatitas.Controllers
{         
     public class FilesController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        public FilesController(IHostingEnvironment hostingEnvironment)
        {
            _appEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> DoUpload(List<IFormFile> files)
        {
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {
                    var file = Image;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "uploads\\img");
                    if (file.Length > 0)
                    {
                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            string filePath = "uploads\\img\\" + fileName;
                            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                            return Redirect(Path.Combine(baseUrl,filePath));
                        }

                    }
                }
            }
            return Json(files.Count);

        }
    }
}