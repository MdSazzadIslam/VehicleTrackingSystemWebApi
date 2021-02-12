using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using VehicleTrackingSystem.Domain.Common;

namespace VehicleTrackingSystem.Domain.Entities
{
    public class DeviceInfo : AuditEntity
    {
        [Key]
        [Column("DEVICE_ID")]
        public int DeviceId { get; set; }

        [Column("DEVICE_NAME")]
        public string DeviceName { get; set; }

        [Column("MANUFACTURER")]
        public string Manufacturer { get; set; }

        [Column("IMEI_NO")]
        public int IMEINo { get; set; }

        [Column("CONTACT_No")]
        public string ContactNo { get; set; }

    }
}
