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
    
    public partial class ConceptForQuestion
    {
        public string ConceptID { get; set; }
        public string QuestionID { get; set; }
        public int St { get; set; }
    
        public virtual ConceptAll ConceptAll { get; set; }
        public virtual Question Question { get; set; }
    }
}
