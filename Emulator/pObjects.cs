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
    
    public partial class pObjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pObjects()
        {
            this.BindingObjectsStepScen = new HashSet<BindingObjectsStepScen>();
        }
    
        public int ID { get; set; }
        public int GIndex { get; set; }
        public string SimIndex { get; set; }
        public int ComputerID { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> Config { get; set; }
        public Nullable<int> AlarmKey { get; set; }
        public Nullable<int> GuardKey { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Workstation { get; set; }
        public Nullable<int> ElementsTypesGroupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BindingObjectsStepScen> BindingObjectsStepScen { get; set; }
    }
}
