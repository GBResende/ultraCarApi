using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UltracarAPI.Models;
using UltracarAPI.Services;
using UltracarAPI.Services.Interfaces;

namespace UltracarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartController : ControllerBase
    {
        private readonly IPartService _partService;

        public PartController(IPartService partService)
        {
            _partService = partService;

        }
        // GET: api/budgets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Part>> GetPartById(int id)
        {
            var Part = await _partService.GetPartByIdAsync(id);
            return Ok(Part);
        }

        [HttpPost]
        public async Task<ActionResult<Part>> postPart([Required] string name, [Required] int quantity)
        {
            var part = new Part
            {
                Name = name,
                Quantity = quantity,
                StockMovements = new List<StockMovement>()
            };

            var budgets = await _partService.AddPartAsync(part);
            return Ok(budgets);
        }
    }
}
