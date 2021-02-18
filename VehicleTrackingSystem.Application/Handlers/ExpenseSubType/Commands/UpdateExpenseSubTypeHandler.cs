using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class UpdateExpenseSubTypeHandler : IRequestHandler<CreateExpenseSubType, ResultModel>
    {
        private readonly IExpenseSubTypeService _expenseSubTypeService;
        private readonly IMapper _mapper;

        public UpdateExpenseSubTypeHandler(IExpenseSubTypeService expenseSubTypeService, IMapper mapper)
        {

            _expenseSubTypeService = expenseSubTypeService ?? throw new ArgumentNullException(nameof(_expenseSubTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ResultModel> Handle(CreateExpenseSubType request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateExpenseSubTypeVm>(request);
            var result = await _expenseSubTypeService.UpdateExpenseSubType(data);
            return result;
        }
    }
}
