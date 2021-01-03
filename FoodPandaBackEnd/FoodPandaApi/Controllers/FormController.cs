using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FoodPandaApi.FormJsons;
using Microsoft.AspNetCore.Mvc;


namespace FoodPandaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpGet("GetFormByFormName")]
        public IActionResult GetFormByFormName([FromQuery][Required] string formName)
        {
            var form = FormGetterService.GetFormModelByFormName(formName);
            if (form != null)
            {
                return Ok(form);
            }
            return NoContent();
        }
    }
}
