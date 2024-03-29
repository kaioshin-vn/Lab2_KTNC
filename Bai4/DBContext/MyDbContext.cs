﻿using A_DAL.Models;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }
        public MyDbContext(DbContextOptions options) : base(options) { }

        //public DbSet<Admin> Admins { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<LichSuKham> lichSuKhams { get; set; }
        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<PhieuKham> PhieuKhams { get; set; }
        public DbSet<ThongBao> ThongBaos { get; set; }
        public DbSet<Luong> Luongs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }
        public DbSet<TrangThaiPhong> TrangThaiPhongs { get; set; }
        public DbSet<TrangThaiNhanVien> TrangThaiNhanViens { get; set; }
        public DbSet<ChamCong> ChamCongs { get; set; }
        public DbSet<GiamGia> GiamGias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DuAn1_C#;Integrated Security=True;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=DuAn1_C#;Integrated Security=True ; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrangThaiNhanVien>()
           .Property(p => p.Id)
           .ValueGeneratedOnAdd()
           .UseIdentityColumn();

            modelBuilder.Entity<TrangThaiPhong>()
           .Property(p => p.Id)
           .ValueGeneratedOnAdd()
           .UseIdentityColumn();

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasIndex(e => e.SoDienThoai).IsUnique();
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasIndex(e => e.SoDienThoai).IsUnique();
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.HasIndex(e => e.Ten).IsUnique();
            });


        }
    }
}
