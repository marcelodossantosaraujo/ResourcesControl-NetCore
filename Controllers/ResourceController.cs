using System.Collections.Generic;
using System.Threading.Tasks;
using APIResources.Data;
using APIResources.Models;
using APIResources.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIResources.Controllers
{
    [ApiController]
    [Route(template:"resources")]
    public class ResourceController : ControllerBase
    {
        [HttpGet]
        [Route(template:"getall")]
        public async Task<IActionResult> GetAll([FromServices]AppDbContext context)
        {
            var resources = await context.Resources.AsNoTracking().ToListAsync();
            return Ok(resources);
        }

        [HttpGet]
        [Route(template:"getbyid/{id}")]
        public async Task<IActionResult> GetById(
                [FromServices]AppDbContext context, 
                [FromRoute] int id)
        {
            var resource = await context.Resources.AsNoTracking().FirstOrDefaultAsync(wh => wh.Id == id);
            return resource == null ? NotFound() : Ok(resource);
        }

        [HttpPost]
        [Route(template:"insert")]
        public async Task<IActionResult> PostAsync(
            [FromServices]AppDbContext context,
            [FromBody] ResourceViewModel resourceViewModel
            )
        {
            if(!ModelState.IsValid)
                return BadRequest();
            var resource = new Resource    
            {
                Description = resourceViewModel.Description,
                Observation = resourceViewModel.Observation
                
            };
            try
            {
                await context.Resources.AddAsync(resource);
                await context.SaveChangesAsync();
                return Created(uri:$"resources/getall/{resource.Id}",resource);
            }
            catch (System.Exception)
            {                
                return BadRequest();
            }
        }
    }

}