using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Apitesting.Data;
using Apitesting.Model;

namespace FormDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FormDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult>PostFormData(FormData formData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.FormDatas.Add(formData);
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostFormData", new { id = formData.Id }, formData);
        }
    }
}

