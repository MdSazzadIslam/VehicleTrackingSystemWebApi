using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    [Table("EXPENSE")]
    public class Expense : AuditableEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EXPENSE_ID")]
        public int ExpenseId { get; set; }
        [Column("EXPENSE_TYPE_ID")] // for example 1 for Fuel
        public int ExpenseTypeId { get; set; }

        [Column("EXPENSE_SUB_TYPE_ID")]  // for example 2 for Liter
        public int ExpenseSubTypeId { get; set; }
        [Column("BILL_NO")]
        public int BillNo { get; set; }
        [Column("QUANTITY")] // it is used for how much liter is used
        public int Quantity { get; set; }

        [Column("BILLING_DATE")]
        [DataType(DataType.Date)]
        public DateTime BillingDate { get; set; }

        [Column("BILLING_AMOUNT")]
        public decimal BillingAmount { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }


        //Foreign Key
        [Column("VEHICLE_ID")]
        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }


    }
}
