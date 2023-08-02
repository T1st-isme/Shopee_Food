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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.DonHang = new HashSet<DonHang>();
            this.DonHangChiTiet = new HashSet<DonHangChiTiet>();
        }
    
        public int MaSP { get; set; }
        public int MaShop { get; set; }
        public int MaDM { get; set; }
        public string TenSP { get; set; }
        public string Loai { get; set; }
        public decimal DonGia { get; set; }
        public Nullable<int> Soluongdaban { get; set; }
        public Nullable<int> Soluongton { get; set; }
    
        public virtual DanhMuc DanhMuc { get; set; }
        public virtual DanhMuc DanhMuc1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHangChiTiet> DonHangChiTiet { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
