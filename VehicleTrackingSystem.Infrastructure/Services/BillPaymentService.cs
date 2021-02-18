using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTrackingSystem.Application.Common.Interfaces;
using VehicleTrackingSystem.Application.Common.Models;
using VehicleTrackingSystem.Application.Handlers.BillPayment;
using VehicleTrackingSystem.Domain.Entities;
using VehicleTrackingSystem.Infrastructure.Data;
using VehicleTrackingSystem.Infrastructure.Utils;

namespace VehicleTrackingSystem.Infrastructure.Services
{
    public class BillPaymentService : IBillPaymentService
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        public BillPaymentService(ICurrentUserService currentUserService, AppDbContext context, IMapper mapper, IDateTime dateTime)
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



        public async Task<ResultModel> CreateBillPayment(BillPaymentVm billPaymentVm)
        {
            try
            {

                var entity = new BillPayment
                {

                    
                    BillNo = billPaymentVm.BillNo,
                    PaymentDate = billPaymentVm.PaymentDate,
                    BillingAmount = billPaymentVm.PaymentAmount,
                    DiscountAmount = billPaymentVm.DiscountAmount,
                    DueAmount = billPaymentVm.DueAmount,
                    PaymentAmount = billPaymentVm.PaymentAmount,

                    
                    CreatedBy = _currentUserService.UserId,
                    CreateDate = _dateTime.Now,

                };

                await _context.BILL_PAYMENT.AddAsync(entity);
                await _context.SaveChangesAsync();
                return new ResultModel
                {
                    Result = true,
                    Message = NotificationConfig.InsertSuccessMessage($"{billPaymentVm.BillNo}"),
                    Id = entity.BillPaymentId.ToString()
                };

            }
            catch(Exception)
            {

                return new ResultModel { Result = false, Message = NotificationConfig.InsertErrorMessage($"{billPaymentVm.BillNo}") };
            }
           
        }


        public async Task<ResultModel> UpdateBillPayment(UpdateBillPaymentVm updateBillPaymentVm)
        {
            try
            {
                var VehicleLocationId = await _context.BILL_PAYMENT.FirstOrDefaultAsync(x => x.BillPaymentId == updateBillPaymentVm.BillPaymentId && !x.Deleted);
                if (VehicleLocationId != null)
                {

                    var entity = new BillPayment
                    {


                        BillNo = updateBillPaymentVm.BillNo,
                        PaymentDate = updateBillPaymentVm.PaymentDate,
                        BillingAmount = updateBillPaymentVm.PaymentAmount,
                        DiscountAmount = updateBillPaymentVm.DiscountAmount,
                        DueAmount = updateBillPaymentVm.DueAmount,
                        PaymentAmount = updateBillPaymentVm.PaymentAmount,

                        UpdateBy = _currentUserService.UserId,
                        UpdateDate = _dateTime.Now,


                    };

                     _context.BILL_PAYMENT.Update(entity);
                    await _context.SaveChangesAsync();
                    return new ResultModel
                    {
                        Result = true,
                        Message = NotificationConfig.InsertSuccessMessage($"{updateBillPaymentVm.BillNo}"),
                        Id = entity.BillPaymentId.ToString()
                    };

                }
                else
                {
                    return new ResultModel { Result = false, Message = NotificationConfig.NotFoundMessage($"{updateBillPaymentVm.BillNo} ") };

                }

                

            }
            catch (Exception)
            {

                return new ResultModel { Result = false, Message = NotificationConfig.UpdateErrorMessage($"{updateBillPaymentVm.BillNo}") };
            }

        }

        public async Task<ResultModel> DeleteBillPayment(int id)
        {
            if (id > 0)
            {
                var entity = await _context.BILL_PAYMENT.FirstOrDefaultAsync(x => x.BillPaymentId == id && x.Deleted == false);
                if (entity != null)
                {
                    entity.Deleted = true;
                    await _context.SaveChangesAsync();
                    return new ResultModel { Result = true, Message = NotificationConfig.DeleteSuccessMessage($"{entity.BillNo}") };
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

      
        public async Task<IList<BillPaymentReturnVm>> GetBillPayment()
        {
            var entity = await _context.BILL_PAYMENT.Where(x => x.Deleted == false).ToListAsync();
            var data = _mapper.Map<IList<BillPaymentReturnVm>>(entity);
            return data;
        }

        public async Task<BillPaymentReturnVm> GetBillPaymentById(int id)
        {
            var entity = await _context.BILL_PAYMENT.FirstOrDefaultAsync(x => x.BillPaymentId == id && !x.Deleted);
            var data = _mapper.Map<BillPaymentReturnVm>(entity);
            return data;
        }
    }
}
