//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lohovskayaProga
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tracking
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public string LoginTime { get; set; }
        public string LogoutTime { get; set; }
        public string TimeSpentOnSystem { get; set; }
        public string UnsuccessfulLogoutReason { get; set; }
        public Nullable<int> CrahTypeID { get; set; }
        public int UsersID { get; set; }
    
        public virtual CrahType CrahType { get; set; }
        public virtual User User { get; set; }
    }
}
