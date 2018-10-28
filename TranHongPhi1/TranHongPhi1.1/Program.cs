using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhap vao so luong sinh vien :");
            n = int.Parse(Console.ReadLine());

            SinhVien[] sv = new SinhVien[n];
            for(int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
            }
            for(int i = 0;i<n;i++)
            {
                sv[i].xuat();
                Console.WriteLine();
            }
            //List<SinhVien> listSV = new List<SinhVien>();
            //for(int i=0; i<n; i++)
            //{
            //    SinhVien sv = new SinhVien();
            //    sv.nhap();
            //    listSV.Add(sv);
            //}
            //listSV.ForEach(item =>
            //{
            //    item.xuat();
            //});
            Console.ReadLine();
        }
    }
}
