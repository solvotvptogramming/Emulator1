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
    
    public partial class BindingGrObjectsStepScen
    {
        public int ID { get; set; }
        public int ID_ScenDevice { get; set; }
        public bool Access { get; set; }
        public int ID_GrObject { get; set; }
    
        public virtual GroupObj GroupObj { get; set; }
        public virtual ScenariosDevice ScenariosDevice { get; set; }
    }
}
