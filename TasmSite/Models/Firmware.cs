namespace TasmSite.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model represents the Firmware entity in the Database
    /// </summary>
    public partial class Firmware
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmware()
        {
            this.Devices = new HashSet<Device>();
            this.Firmware1 = new HashSet<Firmware>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public Nullable<int> PreviousId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        
        /// <summary>
        /// The collection of devices that have this firmware installed
        /// </summary>
        public virtual ICollection<Device> Devices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firmware> Firmware1 { get; set; }
        public virtual Firmware Firmware2 { get; set; }
    }
}
