//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prayer()
        {
            this.AskMinyans = new HashSet<AskMinyan>();
            this.Minyans = new HashSet<Minyan>();
        }
    
        public long IdPrayer { get; set; }
        public string NamePrayer { get; set; }
        public long IdTime { get; set; }
        public long LastTimeToday { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AskMinyan> AskMinyans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Minyan> Minyans { get; set; }
        public virtual TimeAtTheDay TimeAtTheDay { get; set; }
    }
}
