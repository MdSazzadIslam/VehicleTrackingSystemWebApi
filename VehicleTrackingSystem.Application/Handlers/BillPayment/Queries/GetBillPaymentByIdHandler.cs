using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Queries
{
    public class GetBillPaymentByIdHandler : IRequestHandler<GetBillPaymentById, BillPaymentReturnVm>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly IMapper _mapper;
        public GetBillPaymentByIdHandler(IBillPaymentService billPaymentService, IMapper mapper)
        {
            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }

        public async Task<BillPaymentReturnVm> Handle(GetBillPaymentById request, CancellationToken cancellationToken)
        {
            var bills = await _billPaymentService.GetBillPaymentById(request.Id);
            return bills;
        }
    }
}
