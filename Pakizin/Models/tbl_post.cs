//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pakizin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> User_id { get; set; }
        public string Content { get; set; }
    
        public virtual tbl_user tbl_user { get; set; }
    }
}