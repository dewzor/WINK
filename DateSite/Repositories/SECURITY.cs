//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class SECURITY
    {
        public int PID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool VISIBILITY { get; set; }
    
        public virtual Profiles Profiles { get; set; }
    }
}
