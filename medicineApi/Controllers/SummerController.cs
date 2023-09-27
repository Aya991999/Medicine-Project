using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;

namespace medicineApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummerController : ControllerBase
    {
        private readonly Context _context;

        public SummerController(Context context)
        {
            _context = context;
        }

        // GET: api/Summers
        [HttpGet]
        //[ProducesResponseType(204)]
        public async Task<ActionResult<IEnumerable<Summer>>> GetSummers()
        {
            var summer = await _context.Summers
              .Select(s => new Summer
              {
                  Summer_ID = s.Summer_ID,
              })
              .ToListAsync();

            return Ok(summer);
        }


        // POST: api/Summers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Summer>> PostSummer(Summer summer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("من فضلك تأكد من صحة البيانات المدخلة");
            }

            else
            {
                summer.Summer_ID = summer.Summer_ID;
                _context.Summers.Add(summer);
                await _context.SaveChangesAsync();
            }
            return Ok("تمت الاضافة");
        }

        // DELETE: api/Summers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSummer(int id)
        {
            var summer = await _context.Summers.FindAsync(id);
            if (summer == null)
            {
                return NotFound();
            }

            _context.Summers.Remove(summer);
            await _context.SaveChangesAsync();

            return Ok("تم الحذف بنجاح");
        }
    }
}
