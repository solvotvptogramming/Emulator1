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
    
    public partial class RelationDiv
    {
        public int ID { get; set; }
        public int IdAuth { get; set; }
        public int IdDiv { get; set; }
    
        public virtual Authorities Authorities { get; set; }
    }
}
