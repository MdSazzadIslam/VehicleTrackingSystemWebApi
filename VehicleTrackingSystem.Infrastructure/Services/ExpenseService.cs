using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Handlers.Expense;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        public ExpenseService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime)
        {
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _context = context ?? throw new ArgumentNullException(nameof(_context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(dateTime));
        }

        public void Dispose()
        {
            _context.Dispose();
        }


        public async Task<ResultModel> CreateExpense(ExpenseVm expenseVm)
        {
            var entity = new Expense
            {
                ExpenseId = expenseVm.ExpenseId,
                ExpenseTypeId = expenseVm.ExpenseTypeId,
                ExpenseSubTypeId = expenseVm.ExpenseSubTypeId,
                BillNo = expenseVm.BillNo,
                Quantity = expenseVm.Quantity,
                BillingDate = expenseVm.BillingDate,
                BillingAmount = expenseVm.BillingAmount,
                VehicleId = expenseVm.VehicleId,

                UpdateBy = _currentUserService.UserId,
                UpdateDate = _dateTime.Now,
                CreatedBy = _currentUserService.UserId,
                CreateDate = _dateTime.Now,
            };

            await _context.Expense.AddAsync(entity);
            await _context.SaveChangesAsync();
            return new ResultModel
            {
                Result = true,
                Message = NotificationConfig.InsertSuccessMessage($"{expenseVm.BillNo}"),
                Id = entity.ExpenseTypeId.ToString()
            };
        }

        public async Task<ResultModel> DeleteExpense(int id)
        {
            if (id > 0)
            {
                var entity = await _context.Expense.FirstOrDefaultAsync(x => x.ExpenseId == id && x.Deleted == false);
                if (entity != null)
                {
                    entity.Deleted = true;
                    await _context.SaveChangesAsync();
                    return new ResultModel { Result = true, Message = NotificationConfig.DeleteSuccessMessage($"{entity.BillNo}") };
                }
                else
                {
                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundError };
                }
            }
            else
            {
                return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{id}") };
            }
        }

      

        public async Task<IList<ExpenseVm>> GetExpense()
        {
            var entity = await _context.Expense.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<ExpenseVm>>(entity);
            return data;
        }

        public async Task<ExpenseVm> GetExpenseSubById(int id)
        {
            var entity = await _context.Expense.FirstOrDefaultAsync(x => x.ExpenseSubTypeId == id && !x.Deleted);
            var data = _mapper.Map<ExpenseVm>(entity);
            return data;
        }
    }
}
