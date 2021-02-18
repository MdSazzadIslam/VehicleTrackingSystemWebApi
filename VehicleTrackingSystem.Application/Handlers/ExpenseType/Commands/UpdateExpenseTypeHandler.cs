using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseType.Commands
{
    public class UpdateExpenseTypeHandler : IRequestHandler<UpdateExpenseType, ResultModel>
    {
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IMapper _mapper;

        public UpdateExpenseTypeHandler(IExpenseTypeService expenseService, IMapper mapper)
        {

            _expenseTypeService = expenseService ?? throw new ArgumentNullException(nameof(_expenseTypeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ResultModel> Handle(UpdateExpenseType request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateExpenseTypeVm>(request);
            var result = await _expenseTypeService.UpdateExpenseType(data);
            return result;
        }
    }
}
