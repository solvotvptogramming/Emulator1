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
    
    public partial class Script
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public Nullable<int> HotKey { get; set; }
        public Nullable<int> Config { get; set; }
        public byte[] Content { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public string Workstation { get; set; }
    }
}
