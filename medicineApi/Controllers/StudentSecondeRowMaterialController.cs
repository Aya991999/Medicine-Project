using MVCFinalProjectApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCFinalProject.Models;
using DBMedicine.Models;

namespace MVCFinalProject.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentSecondeRowMaterialController : ControllerBase
    {
        private readonly Context _context;

        public StudentSecondeRowMaterialController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Getall()
        {
            var obj = _context.StudentSecondeRowMaterials
                 .Include(e => e.Students)
                 .Include(a => a.Materials)
                 .Include(s => s.Second_Row).ToList();

            List<ssrmDTO> listdto = new List<ssrmDTO>();

            ssrmDTO ssrmdto;

            foreach (var item in obj)
            {
                ssrmdto = new ssrmDTO();
                ssrmdto.Name = _context.Students.Where(a => a.National_ID == item.Std_National_ID).Select(n => n.Full_Name).FirstOrDefault();
                ssrmdto.Material_Name = _context.Materials.Where(a => a.Code == item.Material_Code).Select(n => n.Name).FirstOrDefault();
                ssrmdto.NID = item.Std_National_ID;
                ssrmdto.second_row_id = item.Second_Row_ID;
                ssrmdto.material_code = item.Material_Code;
                ssrmdto.relase = item.Relase;
                ssrmdto.year = item.Year;
                ssrmdto.IsSuccess = item.IsSuccess;

                listdto.Add(ssrmdto);
            }
            return Ok(listdto);
        }

        [HttpGet("{NID:int}")]

        public IActionResult Getone(string NID)
        {
            StudentSecondeRowMaterial obj = _context.StudentSecondeRowMaterials
               .Include(e => e.Students)
               .Include(a => a.Materials)
               .Include(s => s.Second_Row).LastOrDefault(d => d.Std_National_ID == NID);
            if (obj == null)
            {
                return NotFound();
            }
            ssrmDTO ssrmdto = new ssrmDTO();

            ssrmdto.Name = _context.Students.Where(a => a.National_ID == obj.Std_National_ID).Select(n => n.Full_Name).FirstOrDefault();
            ssrmdto.Material_Name = _context.Materials.Where(a => a.Code == obj.Material_Code).Select(n => n.Name).FirstOrDefault();
            ssrmdto.NID = obj.Std_National_ID;
            ssrmdto.material_code = obj.Material_Code;
            ssrmdto.second_row_id = obj.Second_Row_ID;
            ssrmdto.year = obj.Year;
            ssrmdto.relase = obj.Relase;
            ssrmdto.IsSuccess = obj.IsSuccess;


            return Ok(ssrmdto);
        }

        [HttpPut("{NID:int}")]
        public IActionResult update_ssrm(string NID, ssrmDTO ssrmdto)
        {

            StudentSecondeRowMaterial obj = _context.StudentSecondeRowMaterials
                 .Include(e => e.Students)
                 .Include(a => a.Materials)
                 .Include(s => s.Second_Row).FirstOrDefault(d => d.Std_National_ID == NID);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                obj.Second_Row_ID = ssrmdto.second_row_id;
                obj.Year = ssrmdto.year;
                obj.Relase = ssrmdto.relase;
                obj.IsSuccess = ssrmdto.IsSuccess;
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok();
            }
        }
        [HttpPost("{NID:int}")]
        public IActionResult ADD_ssrm(string NID, string material_code, ssrmDTO ssrmdto)
        {
            StudentSecondeRowMaterial obj = _context.StudentSecondeRowMaterials
             .Include(e => e.Students)
             .Include(a => a.Materials)
             .Include(s => s.Second_Row).LastOrDefault(d => d.Std_National_ID == NID && d.Material_Code == material_code);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                if (obj.Relase < 50)
                {
                    StudentSecondeRowMaterial newobj = new StudentSecondeRowMaterial();
                    newobj.Std_National_ID = ssrmdto.NID;
                    newobj.Material_Code = ssrmdto.material_code;
                    newobj.Second_Row_ID = ssrmdto.second_row_id;
                    newobj.Year = ssrmdto.year;
                    newobj.Relase = ssrmdto.relase;
                    newobj.IsSuccess = ssrmdto.IsSuccess;

                    _context.StudentSecondeRowMaterials.Add(newobj);
                    _context.SaveChanges();
                    return Ok();
                }
            }
            return Ok();
        }


        [HttpGet("GetSOSLIDS/{std_ID}/{level}/{semster}")]
        public IActionResult GetSOSLIDS(string std_ID, string level, string semster)
        {
            List<StudentSecondeRowMaterial> studentMaterials = _context.StudentSecondeRowMaterials.Include(ww => ww.Materials).Include(ww => ww.Students).Where(ww => ww.Materials.Level == level && ww.Materials.Semster == semster && ww.Std_National_ID == std_ID).ToList();
            List<ssrmDTO> materials = new List<ssrmDTO>();
            ssrmDTO studentMaterialDTO;
            if (studentMaterials != null)
            {
                foreach (var item in studentMaterials)
                { 
                    studentMaterialDTO = new ssrmDTO();
                    studentMaterialDTO.NID = item.Std_National_ID;
                    studentMaterialDTO.Name = item.Students.Full_Name;
                    studentMaterialDTO.material_code = item.Material_Code;
                    studentMaterialDTO.Material_Name = item.Materials.Name;
                    studentMaterialDTO.relase = item.Relase;
                    studentMaterialDTO.year = item.Year;

                    materials.Add(studentMaterialDTO);
                }
                return Ok(materials);
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPut("PutStudentMaterialsFinalS")]
        public IActionResult PutStudentMaterialsFinalS(string Std_id, string materialcod, float relase)
        {
            
            var studentmaterial = _context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == Std_id && ww.Material_Code == materialcod).FirstOrDefault();
            StudentSecondeRowMaterial sm = new StudentSecondeRowMaterial();
            if (studentmaterial == null)
            {
                return NoContent();
            }

            else if (relase < 50)
            {
                var secondrow = _context.Second_Rows.OrderBy(ww => ww.Second_Row_ID).LastOrDefault();
                DeleteStudentMaterialsToSecondRow(Std_id, materialcod, secondrow.Second_Row_ID);
                studentmaterial.Relase = relase;


                studentmaterial.IsSuccess = false;

                sm.Material_Code = materialcod;
                sm.Std_National_ID = Std_id;
                sm.Year = DateTime.Now.Year.ToString();
                sm.Second_Row_ID = _context.Second_Rows.Select(ww => ww.Second_Row_ID).LastOrDefault();
                _context.StudentSecondeRowMaterials.Add(sm);
                _context.Entry(studentmaterial).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok();

            }
            else if (relase >= 50 && relase < 65)
            {
                try
                {
                    studentmaterial.Relase = relase;


                    studentmaterial.IsSuccess = true;
                    _context.Entry(studentmaterial).State = EntityState.Modified;
                    _context.SaveChanges();

                    return Ok();
                }
                catch
                {
                    return NoContent();
                }

            }
            else
            {
                return BadRequest("Values Not Satisfied");
            }
        }
        [HttpPost("DeleteStudentMaterialsToSecondRow")]
        public IActionResult DeleteStudentMaterialsToSecondRow(string std_national_ID, string matrial_code, int secondRowID)
        {

            try
            {
                var stdsumer = _context.StudentSecondeRowMaterials.Where(ww => ww.Std_National_ID == std_national_ID && ww.Material_Code == matrial_code && ww.Second_Row_ID == secondRowID).FirstOrDefault();
                _context.StudentSecondeRowMaterials.Remove(stdsumer);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("GetStdSecondRowByYear/{year}")]

            public IActionResult GetByYear(string year)
            {
                var obj = _context.StudentSecondeRowMaterials
                   .Include(e => e.Students)
                   .Include(a => a.Materials)
                   .Include(s => s.Second_Row).Where(d => d.Year == year).ToList();
                if (obj == null)
                {
                    return NotFound();
                }
                List<ssrmDTO> ssrmDTOs = new List<ssrmDTO>();
                ssrmDTO ssrmdto;
                StudentSecondeRowMaterial studentSeconde = new StudentSecondeRowMaterial();
                //var stdname = _context.Students.Where(a => a.National_ID == studentSeconde.Std_National_ID).Select(n => n.Full_Name).FirstOrDefault();
                //var materialname= _context.Materials.Where(a => a.Code == studentSeconde.Material_Code).Select(n => n.Name).FirstOrDefault();
                foreach (var item in obj)
                {
                    ssrmdto = new ssrmDTO();
                    ssrmdto.Name = item.Students.Full_Name;         //_context.Students.Where(a => a.National_ID == studentSeconde.Std_National_ID).Select(n => n.Full_Name).FirstOrDefault();
                    ssrmdto.Material_Name = item.Materials.Name;    //_context.Materials.Where(a => a.Code == studentSeconde.Material_Code).Select(n => n.Name).FirstOrDefault();
                    ssrmdto.NID = item.Std_National_ID;
                    ssrmdto.material_code = item.Material_Code;
                    ssrmdto.second_row_id = item.Second_Row_ID;
                    ssrmdto.year = item.Year;
                    ssrmdto.relase = item.Relase;
                    ssrmdto.IsSuccess = item.IsSuccess;
                    ssrmDTOs.Add(ssrmdto);
                }
                return Ok(ssrmDTOs);
            }
        

    }
}


