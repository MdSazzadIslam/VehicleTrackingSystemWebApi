using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Expense
{
    public interface IExpenseService : IDisposable
    {
        public Task<ResultModel> CreateExpense(ExpenseVm expenseVm);
        public Task<ResultModel> DeleteExpense(int id);
        public Task<IList<ExpenseVm>> GetExpense();
        public Task<ExpenseVm> GetExpenseSubById(int id);
    }
}
