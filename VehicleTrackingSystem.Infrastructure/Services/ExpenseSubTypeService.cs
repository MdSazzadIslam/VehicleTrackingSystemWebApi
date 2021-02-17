using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Handlers.ExpenseSubType;
using VehicleTrackingSystem.Application.Handlers.ExpenseType;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class ExpenseSubTypeService : IExpenseSubTypeService
    {

        private readonly ICurrentUserService _currentUserService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        public ExpenseSubTypeService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime)
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

        public async Task<ResultModel> CreateExpenseSubType(ExpenseSubTypeVm expenseSubTypeVm)
        {
            var entity = new ExpenseSubType
            {
                ExpenseTypeId = expenseSubTypeVm.ExpenseTypeId,
                ExpenseSubTypeId = expenseSubTypeVm.ExpenseSubTypeId,
                ExpenseSubTypeName = expenseSubTypeVm.ExpenseSubTypeName,

                UpdateBy = _currentUserService.UserId,
                UpdateDate = _dateTime.Now,
                CreatedBy = _currentUserService.UserId,
                CreateDate = _dateTime.Now,
            };

            await _context.L_EXPENSE_SUB_TYPE.AddAsync(entity);
            await _context.SaveChangesAsync();
            return new ResultModel
            {
                Result = true,
                Message = NotificationConfig.InsertSuccessMessage($"{expenseSubTypeVm.ExpenseSubTypeName}"),
                Id = entity.ExpenseTypeId.ToString()
            };
        }

        public async Task<ResultModel> DeleteExpenseSubType(int id)
        {
            if (id > 0)
            {
                var entity = await _context.L_EXPENSE_SUB_TYPE.FirstOrDefaultAsync(x => x.ExpenseSubTypeId == id && x.Deleted == false);
                if (entity != null)
                {
                    entity.Deleted = true;
                    await _context.SaveChangesAsync();
                    return new ResultModel { Result = true, Message = NotificationConfig.DeleteSuccessMessage($"{entity.ExpenseSubTypeName}") };
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

      
        public async Task<IList<ExpenseSubTypeReturnVm>> GetExpenseSubType()
        {
            var entity = await _context.L_EXPENSE_SUB_TYPE.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<ExpenseSubTypeReturnVm>>(entity);
            return data;
        }

        public async Task<ExpenseSubTypeReturnVm> GetExpenseSubTypeById(int id)
        {
            var entity = await _context.L_EXPENSE_SUB_TYPE.FirstOrDefaultAsync(x => x.ExpenseSubTypeId == id && !x.Deleted);
            var data = _mapper.Map<ExpenseSubTypeReturnVm>(entity);
            return data;
        }
    }
}
