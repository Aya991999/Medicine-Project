using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using medicineApi.DTO;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;

namespace medicineApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly Context _context;

        public DoctorController(Context context)
        {
            _context = context;
        }

        // GET: api/Doctors
        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctors = _context.Doctors.Include(m=>m.Materials).ToList();
            if (doctors.Count > 0)
            {
                List<DOCDTO> doctorDTO = new List<DOCDTO>();
                DOCDTO doctorDTO1;
                foreach (var item in doctors)
                {
                    doctorDTO1 = new DOCDTO();
                    doctorDTO1.ID = item.ID;
                    doctorDTO1.docttorname = item.Name;
                
                    doctorDTO1.Address = item.Address;
                    doctorDTO1.birthDay = item.birthDay;
                    doctorDTO1.National_id=item.National_id;

                    doctorDTO.Add(doctorDTO1);
                }

                return Ok(doctorDTO);
            }
            else
            {
                return NotFound("Data Not Found");
            }
        }

        //        // GET: api/Doctors/5
        [HttpGet("/{id}")]
        public IActionResult GetDoctors(int id)
        {
            var doctors = _context.Doctors.Where(ww => ww.ID == id).Select(ww => ww).FirstOrDefault();
            DOCDTO doctorDTO1 = new DOCDTO();

            if (doctors == null)
            {
                return NotFound();
            }
            else
            {
                doctorDTO1.ID = doctors.ID;
                doctorDTO1.docttorname = doctors.Name;


                doctorDTO1.Address = doctors.Address;
                doctorDTO1.birthDay = doctors.birthDay;
                doctorDTO1.National_id = doctors.National_id;

                return Ok(doctorDTO1);
            }
        }
        [HttpGet("{Name}")]
        public IActionResult GetDoctorsByName(string Name)
        {

            List<Doctors> doctors = _context.Doctors.Where(ww => ww.Name == Name).ToList();
            List<DOCDTO> dto = new List<DOCDTO>();
            DOCDTO doctordto;

            if (doctors == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var item in doctors)
                {
                    doctordto = new DOCDTO();
                    doctordto.ID = item.ID;
                    doctordto.docttorname = item.Name;
                    doctordto.Address = item.Address;
                    doctordto.birthDay = item.birthDay;
                    doctordto.National_id = item.National_id;
                    dto.Add(doctordto);
                }
                return Ok(dto);
            }
        }

        // PUT: api/Doctors/5
        [HttpPut("{id}")]
        public IActionResult PutDoctors(int id, DOCDTO doctors)
        {
            Doctors Doc = _context.Doctors.Where(ww => ww.ID == id).FirstOrDefault();
            DOCDTO doctorDTO = new DOCDTO();
            if (id != doctors.ID)
            {
                return BadRequest();
            }
            else if (Doc == null)
            {
                return BadRequest();
            }
            else
            {
                Doc.Name = doctors.docttorname;
                Doc.Address = doctors.Address;
                Doc.birthDay = doctors.birthDay;
                Doc.National_id = doctors.National_id;
                _context.Entry(Doc).State = EntityState.Modified;

                try
                {
                    _context.SaveChanges();
                    doctorDTO.ID = doctors.ID;
                    doctorDTO.docttorname = doctors.docttorname;
                    doctorDTO.Address = doctors.Address;
                    doctorDTO.birthDay = doctors.birthDay;
                    doctorDTO.National_id = doctors.National_id;
                    return Ok(doctorDTO);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorsExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        // POST: api/Doctors
        [HttpPost]
        public IActionResult PostDoctors(DOCDTO doctors)
        {
            Doctors doc = new Doctors();
            doc.Name = doctors.docttorname;
            doc.National_id = doctors.National_id;
            doc.birthDay = doctors.birthDay;
            doc.Address = doctors.Address;
            var ds = _context.Doctors.Where(d => d.National_id == doctors.National_id).Count();
            if(ds>0)
                return Ok("400");
            _context.Doctors.Add(doc);
            _context.SaveChanges();
            return Ok("200");
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctors(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return Ok("تم الحذف بنجاح");
        }
        private bool DoctorsExists(int id)
        {
            return _context.Doctors.Any(e => e.ID == id);
        }
    }
}
