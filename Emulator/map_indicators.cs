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
    
    public partial class map_indicators
    {
        public int Id { get; set; }
        public int MapElmId { get; set; }
        public double range_min { get; set; }
        public double range_max { get; set; }
        public int range_color { get; set; }
        public int status_range { get; set; }
    
        public virtual Map_Elm Map_Elm { get; set; }
    }
}
