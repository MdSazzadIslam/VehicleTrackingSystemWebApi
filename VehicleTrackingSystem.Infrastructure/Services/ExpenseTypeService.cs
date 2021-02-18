using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Handlers.ExpenseType;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class ExpenseTypeService : IExpenseTypeService
    {

        private readonly ICurrentUserService _currentUserService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        public ExpenseTypeService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime)
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
        public async Task<ResultModel> CreateExpenseType(ExpenseTypeVm expense)
        {
            try
            {
                var entity = new ExpenseType
                {
                    ExpenseTypeName = expense.ExpenseTypeName,

                    CreatedBy = _currentUserService.UserId,
                    CreateDate = _dateTime.Now,
                };

                await _context.L_EXPENSE_TYPE.AddAsync(entity);
                await _context.SaveChangesAsync();
                return new ResultModel
                {
                    Result = true,
                    Message = NotificationConfig.InsertSuccessMessage($"{expense.ExpenseTypeName}"),
                    Id = entity.ExpenseTypeId.ToString()
                };

            }
            catch (Exception)
            {
                return new ResultModel { Result = false, Message = NotificationConfig.InsertErrorMessage($"{expense.ExpenseTypeName}") };

            }


        }

        public async Task<ResultModel> UpdateExpenseType(UpdateExpenseTypeVm updateExpenseTypeVm)
        {
            try
            {
                var VehicleLocationId = await _context.L_EXPENSE_TYPE.FirstOrDefaultAsync(x => x.ExpenseTypeId == updateExpenseTypeVm.ExpenseTypeId && !x.Deleted);
                if (VehicleLocationId != null)
                {
                    var entity = new ExpenseType
                    {
                        ExpenseTypeName = updateExpenseTypeVm.ExpenseTypeName,

                        UpdateBy = _currentUserService.UserId,
                        UpdateDate = _dateTime.Now,

                    };

                     _context.L_EXPENSE_TYPE.Update(entity);
                    await _context.SaveChangesAsync();
                    return new ResultModel
                    {
                        Result = true,
                        Message = NotificationConfig.InsertSuccessMessage($"{updateExpenseTypeVm.ExpenseTypeName}"),
                        Id = entity.ExpenseTypeId.ToString()
                    };

                }
                else
                {
                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{updateExpenseTypeVm.ExpenseTypeName}") };
                }


            }
            catch (Exception)
            {
                return new ResultModel { Result = false, Message = NotificationConfig.UpdateErrorMessage($"{updateExpenseTypeVm.ExpenseTypeName}") };

            }


        }


        public async Task<ResultModel> DeleteExpenseType(int id)
        {
            if (id > 0)
            {
                var entity = await _context.L_EXPENSE_TYPE.FirstOrDefaultAsync(x => x.ExpenseTypeId == id && x.Deleted == false);
                if (entity != null)
                {
                    entity.Deleted = true;
                    await _context.SaveChangesAsync();
              return new ResultModel { Result = true, Message = NotificationConfig.DeleteSuccessMessage($"{entity.ExpenseTypeName}") };
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

        public async Task<IList<ExpenseTypeReturnVm>> GetExpenseType()
        {
            var entity = await _context.L_EXPENSE_TYPE.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<ExpenseTypeReturnVm>>(entity);
            return data;
        }

        public async Task<ExpenseTypeReturnVm> GetExpenseTypeById(int id)
        {
            var entity = await _context.L_EXPENSE_TYPE.FirstOrDefaultAsync(x => x.ExpenseTypeId == id && !x.Deleted);
            var data = _mapper.Map<ExpenseTypeReturnVm>(entity);
            return data;
        }
    }
}
