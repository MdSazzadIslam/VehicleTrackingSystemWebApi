using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment.Queries
{
    public class GetBillPaymentHandler : IRequestHandler<GetBillPayment, IList<Domain.Entities.BillPayment>>
    {
        private readonly IBillPaymentService _billPaymentService;
        private readonly IMapper _mapper;
        public GetBillPaymentHandler(IBillPaymentService billPaymentService, IMapper mapper)
        {
            _billPaymentService = billPaymentService ?? throw new ArgumentNullException(nameof(_billPaymentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));
        }
        public async Task<IList<Domain.Entities.BillPayment>> Handle(GetBillPayment request, CancellationToken cancellationToken)
        {
            var bills = await _billPaymentService.GetBillPayment();
            return _mapper.Map<IList<Domain.Entities.BillPayment>>(bills);

        }
    }
}
