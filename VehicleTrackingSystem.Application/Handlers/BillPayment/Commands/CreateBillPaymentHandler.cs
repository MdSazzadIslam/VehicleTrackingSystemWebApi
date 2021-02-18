using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Commands
{
    public class CreateBillPaymentHandler : IRequestHandler<CreateBillPayment, ResultModel>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly IMapper _mapper;

        public CreateBillPaymentHandler(IBillPaymentService billPaymentService, IMapper mapper)
        {
            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<ResultModel> Handle(CreateBillPayment request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<BillPaymentVm>(request);
            var result = await _billPaymentService.CreateBillPayment(data);
            return result;
        }
    }
}
