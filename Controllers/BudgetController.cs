using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using UltracarAPI.Models;
using UltracarAPI.Services.Interfaces;

namespace UltracarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly IBudgetService _budgetService;

        public BudgetsController(IBudgetService budgetService) 
        { 
            _budgetService = budgetService;
        
        }
        // GET: api/budgets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Budget>> GetBudget(int id)
        {
           var budget = await _budgetService.GetBudgetByIdAsync(id);
            return Ok(budget);
        }

        [HttpGet]
        public async Task<ActionResult<Budget>> GetAllBudgets(int id)
        {
            var budgets = await _budgetService.GetAllBudgetsAsync();
            return Ok(budgets);
        }
        [HttpPost]
        public async Task<ActionResult<Budget>> postBudget([Required] string vehiclePlate, [Required] string customerName)
        {
            var budget = new Budget
            {
                CustomerName = customerName,
                VehiclePlate = vehiclePlate,
                StockMovements = new List<StockMovement>()
            };

            var budgets = await _budgetService.AddBudgetAsync(budget);
            return Ok(budgets);
        }
    }
}
