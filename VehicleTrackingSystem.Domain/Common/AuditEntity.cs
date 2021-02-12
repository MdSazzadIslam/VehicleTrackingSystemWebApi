using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehicleTrackingSystem.Domain.Common
{
    public class AuditEntity
    {
        [Column("CREATE_BY")]
        public string CreatedBy { get; set; }
        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }
        [Column("UPDATE_BY")]
        public string UpdateBy { get; set; }
        [Column("UPDATE_DATE")]
        public DateTime? UpdateDate { get; set; }

    }
}
