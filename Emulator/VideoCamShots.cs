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
    
    public partial class VideoCamShots
    {
        public int Id { get; set; }
        public int CameraID { get; set; }
        public System.DateTime EventTime { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<int> Reserv { get; set; }
    }
}
