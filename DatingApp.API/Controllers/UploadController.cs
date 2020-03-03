using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private IHostingEnvironment _env;

        public UploadController(IHostingEnvironment env)
        {
            _env = env;
        }

        // public IActionResult Index() => View();

        // public IActionResult SingleFile(IFormFile file) 
        // {
        //     var dir = _env.ContentRootPath;

        //     using(var fileStream = new FileStream(Path.Combine(dir,"file.png"), FileMode.Create, FileAccess.Write))
        //     {
        //         file.CopyTo(fileStream);
        //     }

        //     return RedirectToAction("index");
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IList<IFormFile> files) // Index()
        // public async Task<IActionResult> Upload(IFormFile file)
        {
            foreach (IFormFile source in files)
            {
                string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.Trim('"');

                filename = this.EnsureCorrectFilename(filename);

                using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                    await source.CopyToAsync(output);
            }

            // return this.View();
            return Ok();
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }

        private string GetPathAndFilename(string filename)
        {
            // return this.hostingEnvironment.WebRootPath + "\\uploads\\" + filename;
            return this._env.WebRootPath + "\\centrumFiles\\" + filename;
        }

    }
}