//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Musteri()
        {
            this.tbl_Faturalar = new HashSet<tbl_Faturalar>();
            this.tbl_NakliyeRapor = new HashSet<tbl_NakliyeRapor>();
        }
    
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriVergiNo { get; set; }
        public string MusteriAdres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Faturalar> tbl_Faturalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_NakliyeRapor> tbl_NakliyeRapor { get; set; }
    }
}
