//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopee_Food
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHangChiTiet
    {
        public int MaSP { get; set; }
        public int MaCTDH { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<int> Gia { get; set; }
        public Nullable<int> Tongtien { get; set; }
        public int MaHD { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
