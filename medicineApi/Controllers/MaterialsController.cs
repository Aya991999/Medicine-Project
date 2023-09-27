using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using medicineApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;

namespace medicineApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly Context _context;

        public MaterialsController(Context context)
        {
            _context = context;
        }

        // GET: api/Materials
        [HttpGet]
        public IActionResult GetMaterials()
        {
            var material = _context.Materials.Include(ww => ww.Doctors).ToList();
            List<MaterialDTO> materialDTOs = new List<MaterialDTO>();
            MaterialDTO materialDTO;
            if (material != null)
            {
                foreach (var item in material)
                {
                    materialDTO = new MaterialDTO();
                    materialDTO.Name = item.Name;
                    materialDTO.Code = item.Code;
                    materialDTO.Point = item.Point;
                    materialDTO.total_gride = item.total_gride;
                    materialDTO.Semster = item.Semster;
                    materialDTO.Level = item.Level;
                    materialDTO.Stage = item.Stage;
                    materialDTO.Doctor_Name = item.Doctors.Name;

                    materialDTOs.Add(materialDTO);
                }
                return Ok(materialDTOs);
            }
            else
                return NoContent();
        }

        // GET: api/Materials/5
        [HttpGet("{Code}")]
        public ActionResult GetMaterials(string Code)
        {
            var materials = _context.Materials.Include(ww => ww.Doctors).Where(ww => ww.Code == Code).FirstOrDefault();

            if (materials == null)
            {
                return NotFound();
            }
            else
            {

                MaterialDTO materialDTO = new MaterialDTO();
                materialDTO.Name = materials.Name;
                materialDTO.Code = materials.Code;
                materialDTO.Point = materials.Point;
                materialDTO.total_gride = materials.total_gride;
                materialDTO.Semster = materials.Semster;
                materialDTO.Level = materials.Level;
                materialDTO.Stage = materials.Stage;
                materialDTO.Doctor_Name = materials.Doctors.Name;
                return Ok(materialDTO);

            }
        }

        // PUT: api/Materials/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{code}")]
        public IActionResult PutMaterials(string code, MaterialDTO materialDTO)
        {
            if (code != materialDTO.Code)
            {
                return BadRequest();
            }
            else
            {
                Materials materials = new Materials();
                materials.Name = materialDTO.Name;
                materials.Code = materialDTO.Code;
                materials.Point = materialDTO.Point;
                materials.total_gride = materialDTO.total_gride;
                materials.Semster = materialDTO.Semster;
                materials.Level = materialDTO.Level;
                materials.Stage = materialDTO.Stage;
                materials.Doctor_ID = materialDTO.Doctor_ID;
                _context.Entry(materials).State = EntityState.Modified;
                try
                {
                    _context.SaveChanges();
                    return Ok("Added");
                }
                catch
                {
                    if (!MaterialsExists(code))
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

        [HttpGet("GetDoctorMaterials/{ID}")]
        public ActionResult GetDoctorMaterials(int ID)
        {
            var materials = _context.Materials.Include(ww => ww.Doctors).Where(ww => ww.Doctor_ID == ID).ToList();
            List<DOCDTO> dOCDTOs = new List<DOCDTO>();
            DOCDTO dOCDTO;

            if (materials == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var mat in materials)
                {
                    dOCDTO = new DOCDTO();
                    dOCDTO.docttorname = mat.Doctors.Name;
                 
                    dOCDTOs.Add(dOCDTO);
                }

                return Ok(dOCDTOs);
            }
        }
        // POST: api/Materials
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostMaterials(MaterialDTO materialDTO)
        {
            if (materialDTO != null)
            {
                try
                {
                    Materials materials = new Materials();
                    materials.Name = materialDTO.Name;
                    materials.Code = materialDTO.Code;
                    materials.Point = materialDTO.Point;
                    materials.total_gride = materialDTO.total_gride;
                    materials.Semster = materialDTO.Semster;
                    materials.Level = materialDTO.Level;
                    materials.Stage = materialDTO.Stage;
                    materials.Doctor_ID = materialDTO.Doctor_ID;
                    _context.Materials.Add(materials);
                    _context.SaveChanges();
                    return Ok();
                }

                catch
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/Materials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterials(string id)
        {
            var materials = await _context.Materials.FindAsync(id);
            if (materials == null)
            {
                return NotFound();
            }

            _context.Materials.Remove(materials);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MaterialsExists(string id)
        {
            return _context.Materials.Any(e => e.Code == id);
        }
    }
}
