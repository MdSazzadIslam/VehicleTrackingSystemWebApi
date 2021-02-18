using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType
{
    public interface IExpenseSubTypeService : IDisposable
    {
        public Task<ResultModel> CreateExpenseSubType(ExpenseSubTypeVm expenseSubTypeVm);
        public Task<ResultModel> UpdateExpenseSubType(UpdateExpenseSubTypeVm updateExpenseSubType);
        public Task<ResultModel> DeleteExpenseSubType(int id);
        public Task<IList<ExpenseSubTypeReturnVm>> GetExpenseSubType();
        public Task<ExpenseSubTypeReturnVm> GetExpenseSubTypeById(int id);

    }

}
