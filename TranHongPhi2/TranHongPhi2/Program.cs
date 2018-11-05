using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi2
{
    class Program
    {
        static void ThanhToan(ref List<HocVien> dshv, string ten, int tienTT)
        {
            Console.Write("Nhap ten hoc vien muon thanh toan : ");
            ten = Console.ReadLine();
            int d = 0;
            for(int i=0; i<dshv.Count;i++)
            {
                if(dshv[i].Ten == ten)
                {
                    Console.Write("Nhap vao so tien muon thanh toan : ");
                    tienTT = int.Parse(Console.ReadLine());
                    dshv[i].ThanhToan(tienTT);
                    d = 1;
                }
            }
            if(d==0)
            {
                Console.WriteLine("Khong co hoc vien nay");
            }
        }
        static void xuat(List<HocVien> dshv, List<Leader> dsld)
        {
            Console.WriteLine("Danh sach hoc vien");
            dshv.ForEach(item =>
            {
                item.xuat();
                Console.WriteLine();
            });
            Console.WriteLine("Danh sach leader");
            dsld.ForEach(item =>
            {
                item.xuat();
                Console.WriteLine();
            });
        }
        static void HocVienSG(List<HocVien> dshv)
        {
            List<HocVien> hvsg = new List<HocVien>();
            dshv.ForEach(item =>
            {
            if (item.CoNY == false)
                {
                    hvsg.Add(item);
                }
            });
            Random rd = new Random();
            int random = rd.Next(0, hvsg.Count - 1);
            Console.WriteLine("Hoc vien doc than ngau nhien");
            hvsg[random].xuat();
        }
        static void TangCongNo(List<HocVien> dshv)
        {
            List<HocVien> hvCoNY = new List<HocVien>();
            dshv.ForEach(item =>
            {
                if (item.CoNY == true)
                {
                    item.CongNo += 5000;
                }
            });
        }
        static void Main(string[] args)
        {
            string ten;
            string gioiTinh;
            string que;
            bool coNY;
            int congNo;
            string chucVu;
            int tienTT=0;
            List<HocVien> dshv = new List<HocVien>();
            int next = 0;
            Console.WriteLine("Nhap thong tin hoc vien");
            while (true)
            {
                Console.Write("Nhap ten : ");
                ten = Console.ReadLine();
                Console.Write("Nhap gioi tinh : ");
                gioiTinh = Console.ReadLine();
                Console.Write("Nhap que : ");
                que = Console.ReadLine();
                Console.Write("Tinh trang co NY hay chua( nhap true or false) : ");
                coNY = bool.Parse(Console.ReadLine());
                Console.Write("Nhap cong no : ");
                congNo = int.Parse(Console.ReadLine());
                HocVien hv = new HocVien(ten, gioiTinh, que, coNY, congNo);
                dshv.Add(hv);
                Console.Write("0 de dung lai. 1 de tiep tuc : ");
                next = int.Parse(Console.ReadLine());
                if (next == 0)
                {
                    break;
                }
            }
            List<Leader> dsld = new List<Leader>();
            Console.WriteLine("Nhap thong tin Leader");
            while (true)
            {
                Console.Write("Nhap ten : ");
                ten = Console.ReadLine();
                Console.Write("Nhap gioi tinh : ");
                gioiTinh = Console.ReadLine();
                Console.Write("Nhap que : ");
                que = Console.ReadLine();
                Console.Write("Tinh trang co NY hay chua( nhap true or false) : ");
                coNY = bool.Parse(Console.ReadLine());
                Console.Write("Nhap chuc vu : ");
                chucVu = Console.ReadLine();
                Leader ld = new Leader(ten, gioiTinh, que, coNY, chucVu);
                dsld.Add(ld);
                Console.Write("0 de dung lai. 1 de tiep tuc : ");
                next = int.Parse(Console.ReadLine());
                if (next == 0)
                {
                    break;
                }
            }
            ThanhToan(ref dshv, ten, tienTT);
            xuat(dshv, dsld);
            HocVienSG(dshv);
            TangCongNo(dshv);
            Console.ReadLine();
        }
    }
}
