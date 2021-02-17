using MediatR;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class CreateExpenseSubType : IRequest<ResultModel>
    {
        public int ExpenseSubTypeId { get; set; }
        public string ExpenseSubTypeName { get; set; }
        public int ExpenseTypeId { get; set; }

        public CreateExpenseSubType(int expenseSubTypeId, string expenseSubTypeName, int expenseTypeId)
        {
            ExpenseSubTypeId = expenseSubTypeId;
            ExpenseSubTypeName = expenseSubTypeName;
            ExpenseTypeId = expenseTypeId;
        }
    }
}
