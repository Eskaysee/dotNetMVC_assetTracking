namespace TasmSite.Models
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// Model represents the Device entity in the Database
    /// </summary>
    public partial class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public int FirmwareId { get; set; }
    
        public virtual Firmware Firmware { get; set; }
        public virtual DeviceGroup DeviceGroup { get; set; }
    }
}
