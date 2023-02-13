using MedAdvisor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedAdvisor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        [HttpPost]
        [Route("UploadFile")]
        public Response UploadFile([FromForm] Document document)
        {
            Response response = new Response();
            try
            {
                string path = Path.Combine("C:\\Users\\helen\\OneDrive\\Desktop\\New\\Working\\-MedTracker-G1\\src\\MedAdvisor.Api\\Images", document.Name);
                using (Stream stream = new FileStream(path, FileMode.Create))
                {
                    document.file.CopyTo(stream);
                }
                response.StatusCode = 200;
                response.ErrorMessage = "Image Created Successfully";
            }
            catch (Exception ex)
            {
                response.StatusCode = 100;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
