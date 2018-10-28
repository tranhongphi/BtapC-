using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi1
{
    class NhanVien
    {
        private int maNV;
        private string tenNV;
        private int luong1H;
        private int soGioLV;
        private int tienLuong;
        public NhanVien()
        {
            this.maNV = 0;
            this.tenNV = "...";
            this.luong1H = 0;
            this.soGioLV = 0;
            this.tienLuong = getTienLuong();
        }
        public NhanVien(int maNV, string tenNV, int luong1H, int soGioLV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.luong1H = luong1H;
            this.soGioLV = soGioLV;
            this.tienLuong = getTienLuong();
        }
        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Luong1H { get => luong1H; set => luong1H = value; }
        public int SoGioLV { get => soGioLV; set => soGioLV = value; }
        public int TienLuong { get => tienLuong; set => tienLuong = value; }

        public int getTienLuong()
        {
            return luong1H * soGioLV;
        }
        public void nhap()
        {
            Console.Write("Ma NV :");
            this.maNV = int.Parse(Console.ReadLine());
            Console.Write("Ten NV :");
            this.tenNV = Console.ReadLine();
            Console.Write("Luong 1 gio : ");
            this.luong1H = int.Parse(Console.ReadLine());
            Console.Write("So gio lam viec :");
            this.soGioLV = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Ma NV :" +this.maNV);
            Console.WriteLine("Ten NV :" +this.tenNV);
            Console.WriteLine("Luong 1 gio : " +this.luong1H);
            Console.WriteLine("So gio lam viec :" +this.soGioLV);
            Console.WriteLine("Tien Luong :" + getTienLuong());
        }
    }
}
