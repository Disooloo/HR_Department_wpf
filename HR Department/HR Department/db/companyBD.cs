//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_Department.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class companyBD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public companyBD()
        {
            this.vacancy = new HashSet<vacancy>();
        }
    
        public int id { get; set; }
        public string companyName { get; set; }
        public string responsible { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<int> id_vacancy { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string site { get; set; }
        public Nullable<int> full_team_count { get; set; }
        public string dop1 { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancy> vacancy { get; set; }
    }
}
