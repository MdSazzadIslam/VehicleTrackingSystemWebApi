using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.BillPayment
{
    public interface IBillPaymentService : IDisposable
    {
        public Task<ResultModel> CreateBillPayment(BillPaymentVm billPaymentVm);
        public Task<ResultModel> UpdateBillPayment(UpdateBillPaymentVm updateBillPaymentVm);
        public Task<ResultModel> DeleteBillPayment(int id);
        public Task<IList<BillPaymentReturnVm>> GetBillPayment();
        public Task<BillPaymentReturnVm> GetBillPaymentById(int id);

    }
}
