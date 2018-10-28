using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi1
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien();
            NhanVien nv2 = new NhanVien(2, "Nguyen Van A", 30000, 5);
            NhanVien nv3 = new NhanVien();
            nv3.nhap();
            Console.WriteLine();
            nv1.xuat();
            Console.WriteLine();
            nv2.xuat();
            Console.WriteLine();
            nv3.xuat();
            Console.ReadLine();
        }
    }
}
