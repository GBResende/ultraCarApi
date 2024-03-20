//using UltracarAPI.Services.Interfaces;

//namespace UltracarAPI.UseCases
//{
//    public class AddPartToBudgetUseCase
//    {
//        private readonly IPartService _partService;
//        private readonly IBudgetService _budgetService;

//        public AddPartToBudgetUseCase(IPartService partService, IBudgetService budgetService)
//        {
//            _partService = partService;
//            _budgetService = budgetService;
//        }

//        public async Task<bool> ExecuteAsync(int budgetId, int partId)
//        {
//            var budget = await _budgetService.GetBudgetByIdAsync(budgetId);
//            var part = await _partService.GetPartByIdAsync(partId);

//            if (budget == null || part == null)
//            {
//                return false; // Or throw an exception
//            }

//            budget.Parts.Add(part);
//            await _budgetService.UpdateBudgetAsync(budget);

//            return true;
//        }
//    }
//}
