using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment
{
    public interface IBillPaymentService : IDisposable
    {
        public Task<Result> CreateBillPayment(Domain.Entities.BillPayment billPayment);
        public Task<Result> DeleteBillPayment(int id);
        public Task<IList<Domain.Entities.BillPayment>> GetBillPayment();
        public Task<IList<Domain.Entities.BillPayment>> GetBillPaymentById(string searchBy);

    }
}
