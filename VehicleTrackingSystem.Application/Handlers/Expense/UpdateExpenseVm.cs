using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Mappers;
using VehicleTrackingSystem.Application.Handlers.Expense.Commands;

namespace VehicleTrackingSystem.Application.Handlers.Expense
{
    public class UpdateExpenseVm : IMapFrom<UpdateExpense>
    {
        public int ExpenseId { get; set; }
        public int ExpenseTypeId { get; set; }
        public int ExpenseSubTypeId { get; set; }
        public int BillNo { get; set; }
        public int Quantity { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal BillingAmount { get; set; }
        public int VehicleId { get; set; }

    }
 
}
