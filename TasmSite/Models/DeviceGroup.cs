namespace TasmSite.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Model represents the DeviceGroup entity in the Database
    /// </summary>
    public partial class DeviceGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeviceGroup()
        {
            this.Devices = new HashSet<Device>();
            this.DeviceGroup1 = new HashSet<DeviceGroup>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentGroupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        
        /// <summary>
        /// Collection of children Groups
        /// </summary>
        public virtual ICollection<DeviceGroup> DeviceGroup1 { get; set; }
        
        /// <summary>
        /// Represents the Base/Super Grouping.
        /// </summary>
        /// <returns>The group that this one is derived from</returns>
        public virtual DeviceGroup DeviceGroup2 { get; set; }
    }
}
