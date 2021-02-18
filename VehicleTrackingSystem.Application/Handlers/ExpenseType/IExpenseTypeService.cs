using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType
{
    public interface IExpenseTypeService : IDisposable
    {
        public Task<ResultModel> CreateExpenseType(ExpenseTypeVm expenseTypeVm);
        public Task<ResultModel> UpdateExpenseType(UpdateExpenseTypeVm updateExpenseTypeVm);
        public Task<ResultModel> DeleteExpenseType(int id);
        public Task<IList<ExpenseTypeReturnVm>> GetExpenseType();
        public Task<ExpenseTypeReturnVm> GetExpenseTypeById(int id);

    }
}
