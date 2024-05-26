using mas_services.Entity;
using mas_services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mas_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person_company_controller : ControllerBase
    {
        private readonly dbContext _context;
        public Person_company_controller(dbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("api/getPersonCompany")]
        public async Task<ActionResult<IEnumerable<MAS_person_company>>> GetPersonCompany()
        {
            try
            {
                return await _context.MAS_PERSON_COMPANY!.Include(p => p.MAS_Type_Identification).Include(p => p.MAS_position).ToListAsync();
            }
            catch
            {
                return BadRequest("Error interno: Por favor contacte con soporte para solventar este problema");
            }
        }
        [HttpPost]
        [Route("api/createPersonCompany")]
        public async Task<ActionResult<MAS_person_company>> CreatePersonCompany([FromBody] MAS_person_company personCompany)
        {
            try
            {

                MAS_type_identification? valueIdentification = await _context.MAS_TYPE_IDENTIFICATION!.FirstOrDefaultAsync(p => p.TYP_ID == personCompany.PER_FK_TYPE_IDENTIFICATION);
               MAS_position? valuePosition = await _context.MAS_POSITION!.FirstOrDefaultAsync(p => p.POS_ID == personCompany.PER_FK_POSITION);
                if (valueIdentification == null)
                {
                    return BadRequest("Error interno: No existe el tipo de intentificación ingresado");
                }
                if (valuePosition == null)
                {
                    return BadRequest("Error interno: No existe el tipo de intentificación ingresado");
                }
                personCompany.MAS_Type_Identification = valueIdentification ;
                personCompany.MAS_position = valuePosition;

                _context.MAS_PERSON_COMPANY!.Add(personCompany);
                await _context.SaveChangesAsync();

                // Devolver el objeto creado con el código de estado 201 Created
                return CreatedAtAction(nameof(GetPersonCompany), new { id = personCompany.PER_ID }, personCompany);
            }
            catch
            {
                return BadRequest("Error interno: Por favor contacte con soporte para solventar este problema");
            }
        }

    }
}
