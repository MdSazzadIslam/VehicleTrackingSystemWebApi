using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Commands
{
   public class UpdateBillPaymentHandler : IRequestHandler<UpdateBillPayment, ResultModel>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly IMapper _mapper;

        public UpdateBillPaymentHandler(IBillPaymentService billPaymentService, IMapper mapper)
        {
            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ResultModel> Handle(UpdateBillPayment request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<UpdateBillPaymentVm>(request);
            var result = await _billPaymentService.UpdateBillPayment(data);
            return result;
        }
    }
}
