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
    
    public partial class evidencija_hospitalizacije
    {
        public string evidencija_hospitalizacijeID { get; set; }
        public Nullable<System.DateTime> boravio_od_datuma { get; set; }
        public Nullable<System.DateTime> boravio_do_datuma { get; set; }
        public string naziv_bolnice { get; set; }
        public string razlog { get; set; }
        public Nullable<int> pacijentiID { get; set; }
    
        public virtual pacijenti pacijenti { get; set; }
    }
}
