using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.ExpenseSubType.Commands
{
    public class CreateExpenseSubTypeHandler : IRequestHandler<CreateExpenseSubType, ResultModel>
    {
        private readonly IExpenseSubTypeService _expenseSubTypeService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;
        private readonly IMapper _mapper;

        public CreateExpenseSubTypeHandler(IExpenseSubTypeService expenseSubTypeService, ICurrentUserService currentUserService, IDateTime dateTime, IMapper mapper)
        {

            _expenseSubTypeService = expenseSubTypeService ?? throw new ArgumentNullException(nameof(_expenseSubTypeService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(_currentUserService));
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(_dateTime));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }


        public async Task<ResultModel> Handle(CreateExpenseSubType request, CancellationToken cancellationToken)
        {

            var data = _mapper.Map<ExpenseSubTypeVm>(request);
            var result = await _expenseSubTypeService.CreateExpenseSubType(data);
            return result;
        }
    }
}
