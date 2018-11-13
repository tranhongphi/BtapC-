using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyOng quanLy = new QuanLyOng();
            int n = 1;
            while(n!=0)
            {
                Console.WriteLine("1.Tao danh sach ong");
                Console.WriteLine("2.Tan cong");
                Console.WriteLine("3.Thoat");
                Console.Write("Nhap vao lua chon cua ban : ");
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        quanLy.taoDanhSachOng();
                        quanLy.xuatDanhSachOng();
                        break;
                    case 2:
                        quanLy.tanCong();
                        quanLy.xuatDanhSachOng();
                        break;
                    case 3:
                        n = 0;
                        break;
                    default:
                        Console.WriteLine("Chon sai");
                        break;
                  
                }
            }
            Console.ReadLine();
        }
    }
}
