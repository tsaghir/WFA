//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseMed.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class lijekovi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lijekovi()
        {
            this.recepti = new HashSet<recepti>();
        }
    
        public int lijekoviID { get; set; }
        public string naziv { get; set; }
        public Nullable<System.DateTime> datum_vrijeme_kontrole { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<System.DateTime> rok_trajanja { get; set; }
        public Nullable<decimal> cijena { get; set; }
        public Nullable<int> sifra_zdrv_ustanoveID { get; set; }
    
        public virtual sifra_zdrv_ustanove sifra_zdrv_ustanove { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recepti> recepti { get; set; }
    }
}
