//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoCCM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MapOfUser
    {
        public MapOfUser()
        {
            this.LinkOfMaps = new HashSet<LinkOfMap>();
        }
    
        public string MapID { get; set; }
        public string MapName { get; set; }
        public string UserID { get; set; }
    
        public virtual ICollection<LinkOfMap> LinkOfMaps { get; set; }
        public virtual User User { get; set; }
    }
}
