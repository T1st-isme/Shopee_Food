//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopee_Food.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhanQuyen
    {
        public int MaTK { get; set; }
        public int MaCV { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        public virtual User User { get; set; }
    }
}