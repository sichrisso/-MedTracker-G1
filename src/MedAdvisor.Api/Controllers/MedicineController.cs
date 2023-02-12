using Microsoft.AspNetCore.Http;

using MedAdvisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MedAdvisor.Services.Okta.MedicineService;
using MedAdvisor.DataAccess.Mysql;

namespace MedAdvisor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;
        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Medicine>>> GetAllMedicines()
        {

            return _medicineService.GetAllMedicines();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Medicine>> GetSingleMedicine(int id)
        {
            return _medicineService.GetSingleMedicine(id);

        }
        [HttpPost]
        public async Task<ActionResult<List<Medicine>>> AddMedicine([FromBody] Medicine medicine)
        {
            var result = _medicineService.AddMedicine(medicine);

            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Medicine>>> UpdateMedicine(int id, Medicine request)
        {
            var result = _medicineService.UpdateMedicine(id, request);
            if (result is null)
            {
                return NotFound("Medicine not Found");
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Medicine>>> DeleteMedicine(int id, Medicine request)
        {
            var result = _medicineService.DeleteMedicine(id);
            if (result is null) { return NotFound("Medicine Not Found "); }

            return Ok(result);

        }


    }
}
