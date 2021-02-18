using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleTrackingSystem.Application.Common.Models;

namespace VehicleTrackingSystem.Application.Handlers.Expense.Commands
{
    public class CreateExpense : IRequest<ResultModel>
    {
        public int ExpenseId { get; set; }
        public int BillNo { get; set; }
        public int ExpenseTypeId { get; set; }
        public int ExpenseSubTypeId { get; set; }
        public DateTime BillingDate { get; set; }
        public double BillingAmount { get; set; }
        public int VehicleId { get; set; }

        public CreateExpense(int expenseId, int expenseTypeId, int expenseSubTypeId,  DateTime billingDate, int billNo, double billingAmount, int vechicleId)
        {
            ExpenseId = expenseId;
            ExpenseTypeId = expenseTypeId;
            ExpenseSubTypeId = expenseSubTypeId;
            BillingDate = billingDate;
            BillNo = billNo;
            BillingAmount = billingAmount;
            VehicleId = vechicleId;
        }
    }
}
