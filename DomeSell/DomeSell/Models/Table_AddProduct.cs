//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomeSell.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_AddProduct
    {
        public int A_AddProID { get; set; }
        public Nullable<int> A_Product { get; set; }
        public Nullable<int> A_amount { get; set; }
        public string A_date { get; set; }
        public Nullable<int> A_StatusAdd { get; set; }
    
        public virtual Table_Product Table_Product { get; set; }
        public virtual Table_StatusAdd Table_StatusAdd { get; set; }
    }
}
