//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emulator
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kone_KGS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kone_KGS()
        {
            this.Kone_COP = new HashSet<Kone_COP>();
            this.Kone_COPGlobalDefaultAccessMask = new HashSet<Kone_COPGlobalDefaultAccessMask>();
            this.Kone_DOPGlobalDefaultAccessMask = new HashSet<Kone_DOPGlobalDefaultAccessMask>();
            this.Kone_DOP = new HashSet<Kone_DOP>();
        }
    
        public int ID { get; set; }
        public int RSLines_ID { get; set; }
        public string Name { get; set; }
        public string PrimaryHost { get; set; }
        public int PrimaryPort { get; set; }
        public string BackupHost { get; set; }
        public int BackupPort { get; set; }
        public Nullable<int> Floors { get; set; }
        public short ByteOrder { get; set; }
        public int HeartBeatOutTimeOut { get; set; }
        public int HeartBeatInTimeOut { get; set; }
        public int ReConnectTimeOut { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kone_COP> Kone_COP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kone_COPGlobalDefaultAccessMask> Kone_COPGlobalDefaultAccessMask { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kone_DOPGlobalDefaultAccessMask> Kone_DOPGlobalDefaultAccessMask { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kone_DOP> Kone_DOP { get; set; }
        public virtual RSLines RSLines { get; set; }
    }
}