using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json;
using UltracarAPI.Models;
using UltracarAPI.Services.Interfaces;
using UltracarAPI.Utils.Enums;
using UltracarAPI.Utils.Mapper;
using UltracarAPI.UseCases.Interfaces;

namespace UltracarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockMovementController : ControllerBase
    {
        private readonly IStockMovementService _stockMovementService;
        private readonly IAddPartToBudgetUseCase _addPartToBudgetUseCase;
        private readonly ISettleBudgetUseCase _settleBudgetUseCase;

        public StockMovementController(IStockMovementService stockMovementService, IAddPartToBudgetUseCase addPartToBudgetUseCase, ISettleBudgetUseCase settleBudgetUseCase)
        {
            _stockMovementService = stockMovementService;
            _addPartToBudgetUseCase = addPartToBudgetUseCase;
            _settleBudgetUseCase = settleBudgetUseCase;
        }
        // GET: api/budgets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Part>> GetStockMovementById(int id)
        {
            var stockMovement = await _stockMovementService.GetStockMovementByIdAsync(id);

            var stockMovementDto = StockMovementMapper.MapToDto(stockMovement);

            return Ok(stockMovementDto);
        }

        [HttpPost]
        public async Task<ActionResult<StockMovement>> postStockMovement([Required] int partId, [Required] int budgetId, [Required] int quantity, [Required] MovementType movementType )
        {
            var stockMovement = new StockMovement()
            {
                PartId = partId,
                BudgetId = budgetId,
                Quantity = quantity,
                MovementType = movementType
            };

            var output = await _addPartToBudgetUseCase.ExecuteAsync(stockMovement);

            if (output)
            {
                return Ok(stockMovement);
            }

            return BadRequest("Adding the part to the budget failed, check the fields and try again");
        }

        [HttpPut]
        public async Task<ActionResult<StockMovement>> postSettleBudgetStockMovement([Required] int stockMovementId)
        {

            var output = await _settleBudgetUseCase.ExecuteAsync(stockMovementId);

            if (output)
            {
                return Ok(output);
            }

            return BadRequest("error to try settle this budget");
        }
    }
}
