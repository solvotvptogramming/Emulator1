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
    
    public partial class Kone_DopAccess
    {
        public int ID_Dop { get; set; }
        public int ID_Access { get; set; }
        public short Floor { get; set; }
        public short DF { get; set; }
        public short DR { get; set; }
    
        public virtual GrAccess GrAccess { get; set; }
    }
}
