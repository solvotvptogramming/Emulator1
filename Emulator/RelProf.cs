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
    
    public partial class RelProf
    {
        public int ID { get; set; }
        public int IDListComp { get; set; }
        public int IDProfiles { get; set; }
        public Nullable<int> Reserve { get; set; }
    
        public virtual ListComponents ListComponents { get; set; }
        public virtual ProFiles ProFiles { get; set; }
    }
}