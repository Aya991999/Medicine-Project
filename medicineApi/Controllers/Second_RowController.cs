using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCFinalProject.Models;

namespace medicineApi.controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class secondroundController : ControllerBase
    {
        private Context context;
        public secondroundController(Context context)
        {
            this.context = context;
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public IActionResult AllSecondRound()
        {
            List<Second_Row> secondrows = context.Second_Rows.ToList();
            return Ok(secondrows);
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet("{id}")]
        // [Route("{id}")]
        public IActionResult Onesecondrow(int id)
        {
            Second_Row SecondRow = context.Second_Rows.FirstOrDefault(d => d.Second_Row_ID == id);
            return Ok(SecondRow);
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        public IActionResult Addsecondrow(Second_Row SecondRow)
        {
            context.Second_Rows.Add(SecondRow);
            context.SaveChanges();
            //string url = Url.Link("GetOneSecondRow", new { year = SecondRow.Year });
            return Ok(SecondRow);
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        //[HttpPut]
        //public IActionResult Updatesecondrow( string year,Second_Row SecondRow)
        //{
        //    Second_Row OldSecondRow = context.Second_Rows.FirstOrDefault(d => d.Year == year);
        //    if (OldSecondRow == null)
        //    {
        //        return NotFound();
        //    }
        //    OldSecondRow.Year = SecondRow.Year;
        //    context.SaveChanges();
        //    return Ok();
        //}
        [HttpDelete]
        public async Task<IActionResult> Deletesecondrow(int id)
        {
            Second_Row secondrow = context.Second_Rows.FirstOrDefault(d => d.Second_Row_ID == id);
            if (secondrow == null)
            {
                return NotFound();
            }

            context.Second_Rows.Remove(secondrow);
            await context.SaveChangesAsync();

            return NoContent();
        }

    }
}
