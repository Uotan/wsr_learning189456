//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Med.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public patients()
        {
            this.patients_blood = new HashSet<patients_blood>();
        }
    
        public int code { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public Nullable<System.DateTime> datebirth { get; set; }
        public Nullable<int> passport_ser { get; set; }
        public Nullable<int> passport_num { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<int> social_sec_number { get; set; }
        public Nullable<int> social_type { get; set; }
        public Nullable<int> insurance_company { get; set; }
        public Nullable<int> country { get; set; }
        public string ein { get; set; }
        public string guid { get; set; }
        public Nullable<bool> is_deleted { get; set; }
    
        public virtual countries countries { get; set; }
        public virtual insurance_companies insurance_companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patients_blood> patients_blood { get; set; }
        public virtual social_types social_types { get; set; }
    }
}
