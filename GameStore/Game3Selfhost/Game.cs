//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Selfhost
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int GameCode { get; set; }
        public string GameName { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public byte[] DateTimeLastMod { get; set; }
        public string GameGenre { get; set; }
    
        public virtual Genre Genre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
