using Microsoft.AspNetCore.Mvc;
using UltracarAPI.Models;
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

        //[HttpGet]
        //public async Task<ActionResult<Budget>> GetAllBudgets(int id)
        //{
        //    var budgets = await _budgetService.GetAllBudgetsAsync();
        //    return Ok(budgets);
        //}
    }
}
