using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;

namespace VehicleTrackingSystem.Application.Handlers.Expense
{
    public class ExpenseReturnVm : IMapFrom<Domain.Entities.Expense>
    {
        public int ExpenseId { get; set; }
        public int ExpenseTypeId { get; set; }
        public int ExpenseSubTypeId { get; set; }
        public int Quantity { get; set; }
        public int BillNo { get; set; }
        public DateTime BillingDate { get; set; }
        public double BillingAmount { get; set; }
        public int VehicleId { get; set; }
    }
}
