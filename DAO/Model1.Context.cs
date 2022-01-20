﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class qlCoffeeP2TEntities : DbContext
    {
        public qlCoffeeP2TEntities()
            : base("name=qlCoffeeP2TEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BANPHUCVU> BANPHUCVUs { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_SanPham> CT_SanPham { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    
        public virtual int CapNhatTK(string tentk, string mk, string manv, string loaitk)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var loaitkParameter = loaitk != null ?
                new ObjectParameter("loaitk", loaitk) :
                new ObjectParameter("loaitk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CapNhatTK", tentkParameter, mkParameter, manvParameter, loaitkParameter);
        }
    
        public virtual int DoiMK(string tentk, string matkhau)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DoiMK", tentkParameter, matkhauParameter);
        }
    
        public virtual ObjectResult<KiemTraTK_Result> KiemTraTK(string tentk, string mk)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KiemTraTK_Result>("KiemTraTK", tentkParameter, mkParameter);
        }
    
        public virtual int SuaBan(Nullable<int> masoban, Nullable<int> soghe)
        {
            var masobanParameter = masoban.HasValue ?
                new ObjectParameter("masoban", masoban) :
                new ObjectParameter("masoban", typeof(int));
    
            var sogheParameter = soghe.HasValue ?
                new ObjectParameter("soghe", soghe) :
                new ObjectParameter("soghe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaBan", masobanParameter, sogheParameter);
        }
    
        public virtual int SuaCTSP(string masp, string manl)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var manlParameter = manl != null ?
                new ObjectParameter("manl", manl) :
                new ObjectParameter("manl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaCTSP", maspParameter, manlParameter);
        }
    
        public virtual int SuaHD(Nullable<int> mahd, Nullable<int> masoban, Nullable<decimal> tongtien)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var masobanParameter = masoban.HasValue ?
                new ObjectParameter("masoban", masoban) :
                new ObjectParameter("masoban", typeof(int));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaHD", mahdParameter, masobanParameter, tongtienParameter);
        }
    
        public virtual int SuaNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            var tennccParameter = tenncc != null ?
                new ObjectParameter("tenncc", tenncc) :
                new ObjectParameter("tenncc", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaNCC", manccParameter, tennccParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int SuaNL(string manl, string tennl, string mancc, string donvitinh, Nullable<decimal> dongia, Nullable<int> sltonkho)
        {
            var manlParameter = manl != null ?
                new ObjectParameter("manl", manl) :
                new ObjectParameter("manl", typeof(string));
    
            var tennlParameter = tennl != null ?
                new ObjectParameter("tennl", tennl) :
                new ObjectParameter("tennl", typeof(string));
    
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            var donvitinhParameter = donvitinh != null ?
                new ObjectParameter("donvitinh", donvitinh) :
                new ObjectParameter("donvitinh", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var sltonkhoParameter = sltonkho.HasValue ?
                new ObjectParameter("sltonkho", sltonkho) :
                new ObjectParameter("sltonkho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaNL", manlParameter, tennlParameter, manccParameter, donvitinhParameter, dongiaParameter, sltonkhoParameter);
        }
    
        public virtual int SuaNV(string manv, string tennv, Nullable<System.DateTime> ngaysinh, Nullable<System.DateTime> ngayvaolam, string gioitinh, string chucvu, string sdt, string email)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var ngayvaolamParameter = ngayvaolam.HasValue ?
                new ObjectParameter("ngayvaolam", ngayvaolam) :
                new ObjectParameter("ngayvaolam", typeof(System.DateTime));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var chucvuParameter = chucvu != null ?
                new ObjectParameter("chucvu", chucvu) :
                new ObjectParameter("chucvu", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaNV", manvParameter, tennvParameter, ngaysinhParameter, ngayvaolamParameter, gioitinhParameter, chucvuParameter, sdtParameter, emailParameter);
        }
    
        public virtual int SuaSP(string masp, string tensp, Nullable<decimal> dongia, string hinhanh)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SuaSP", maspParameter, tenspParameter, dongiaParameter, hinhanhParameter);
        }
    
        public virtual int ThemBan(Nullable<int> soghe)
        {
            var sogheParameter = soghe.HasValue ?
                new ObjectParameter("soghe", soghe) :
                new ObjectParameter("soghe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemBan", sogheParameter);
        }
    
        public virtual int ThemCTHD(Nullable<int> mahd, string masp, Nullable<int> sl, Nullable<decimal> dongia)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemCTHD", mahdParameter, maspParameter, slParameter, dongiaParameter);
        }
    
        public virtual int ThemCTSP(string masp, string manl)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var manlParameter = manl != null ?
                new ObjectParameter("manl", manl) :
                new ObjectParameter("manl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemCTSP", maspParameter, manlParameter);
        }
    
        public virtual int ThemHD(Nullable<int> masoban, string manv, Nullable<decimal> tongtien)
        {
            var masobanParameter = masoban.HasValue ?
                new ObjectParameter("masoban", masoban) :
                new ObjectParameter("masoban", typeof(int));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var tongtienParameter = tongtien.HasValue ?
                new ObjectParameter("tongtien", tongtien) :
                new ObjectParameter("tongtien", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemHD", masobanParameter, manvParameter, tongtienParameter);
        }
    
        public virtual int ThemNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            var tennccParameter = tenncc != null ?
                new ObjectParameter("tenncc", tenncc) :
                new ObjectParameter("tenncc", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemNCC", manccParameter, tennccParameter, diachiParameter, sdtParameter);
        }
    
        public virtual int ThemNL(string manl, string tennl, string mancc, string donvitinh, Nullable<decimal> dongia, Nullable<int> sltonkho)
        {
            var manlParameter = manl != null ?
                new ObjectParameter("manl", manl) :
                new ObjectParameter("manl", typeof(string));
    
            var tennlParameter = tennl != null ?
                new ObjectParameter("tennl", tennl) :
                new ObjectParameter("tennl", typeof(string));
    
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            var donvitinhParameter = donvitinh != null ?
                new ObjectParameter("donvitinh", donvitinh) :
                new ObjectParameter("donvitinh", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var sltonkhoParameter = sltonkho.HasValue ?
                new ObjectParameter("sltonkho", sltonkho) :
                new ObjectParameter("sltonkho", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemNL", manlParameter, tennlParameter, manccParameter, donvitinhParameter, dongiaParameter, sltonkhoParameter);
        }
    
        public virtual int ThemNV(string manv, string tennv, Nullable<System.DateTime> ngaysinh, Nullable<System.DateTime> ngayvaolam, string gioitinh, string chucvu, string sdt, string email)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var tennvParameter = tennv != null ?
                new ObjectParameter("tennv", tennv) :
                new ObjectParameter("tennv", typeof(string));
    
            var ngaysinhParameter = ngaysinh.HasValue ?
                new ObjectParameter("ngaysinh", ngaysinh) :
                new ObjectParameter("ngaysinh", typeof(System.DateTime));
    
            var ngayvaolamParameter = ngayvaolam.HasValue ?
                new ObjectParameter("ngayvaolam", ngayvaolam) :
                new ObjectParameter("ngayvaolam", typeof(System.DateTime));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var chucvuParameter = chucvu != null ?
                new ObjectParameter("chucvu", chucvu) :
                new ObjectParameter("chucvu", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemNV", manvParameter, tennvParameter, ngaysinhParameter, ngayvaolamParameter, gioitinhParameter, chucvuParameter, sdtParameter, emailParameter);
        }
    
        public virtual int ThemSP(string masp, string tensp, Nullable<decimal> dongia, string hinhanh)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemSP", maspParameter, tenspParameter, dongiaParameter, hinhanhParameter);
        }
    
        public virtual int ThemTK(string tentk, string mk, string manv, string loaitk)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            var mkParameter = mk != null ?
                new ObjectParameter("mk", mk) :
                new ObjectParameter("mk", typeof(string));
    
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            var loaitkParameter = loaitk != null ?
                new ObjectParameter("loaitk", loaitk) :
                new ObjectParameter("loaitk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemTK", tentkParameter, mkParameter, manvParameter, loaitkParameter);
        }
    
        public virtual int XoaBan(Nullable<int> masoban)
        {
            var masobanParameter = masoban.HasValue ?
                new ObjectParameter("masoban", masoban) :
                new ObjectParameter("masoban", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaBan", masobanParameter);
        }
    
        public virtual int XoaCTHD(Nullable<int> mahd, string masp)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaCTHD", mahdParameter, maspParameter);
        }
    
        public virtual int XoaCTSP(string masp)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaCTSP", maspParameter);
        }
    
        public virtual int XoaHD(Nullable<int> mahd)
        {
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("mahd", mahd) :
                new ObjectParameter("mahd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaHD", mahdParameter);
        }
    
        public virtual int XoaNCC(string mancc)
        {
            var manccParameter = mancc != null ?
                new ObjectParameter("mancc", mancc) :
                new ObjectParameter("mancc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaNCC", manccParameter);
        }
    
        public virtual int XoaNL(string manl)
        {
            var manlParameter = manl != null ?
                new ObjectParameter("manl", manl) :
                new ObjectParameter("manl", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaNL", manlParameter);
        }
    
        public virtual int XoaNV(string manv)
        {
            var manvParameter = manv != null ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaNV", manvParameter);
        }
    
        public virtual int XoaSP(string masp)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaSP", maspParameter);
        }
    
        public virtual int XoaTK(string tentk)
        {
            var tentkParameter = tentk != null ?
                new ObjectParameter("tentk", tentk) :
                new ObjectParameter("tentk", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaTK", tentkParameter);
        }
    }
}