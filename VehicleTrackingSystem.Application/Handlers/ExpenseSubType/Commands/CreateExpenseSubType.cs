using MediatR;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class CreateExpenseSubType : IRequest<ResultModel>
    {
        public string ExpenseSubTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

        public CreateExpenseSubType(string expenseSubTypeName, int expenseTypeId)
        {
            ExpenseSubTypeName = expenseSubTypeName;
            ExpenseTypeId = expenseTypeId;
        }
    }
}
