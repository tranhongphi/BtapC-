using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi11
{
    public class SinhVien
    {
        private int maSV;
        private string tenSV;
        private float diemTB;

        public float DiemTB { get => diemTB; set => diemTB = value; }

        public void nhap()
        {
            Console.Write("Ma SV :");
            this.maSV = int.Parse(Console.ReadLine());
            Console.Write("Ten SV :");
            this.tenSV = Console.ReadLine();
            Console.Write("Diem TB : ");
            this.DiemTB = float.Parse(Console.ReadLine());
        }
        public string getHocLuc()
        {
            if(DiemTB<5)
            {
                return "Yếu";
            }
            else if(DiemTB<7)
            {
                return "Trung Bình";
            }
            else if(DiemTB<8)
            {
                return "Khá";
            }
            else if(DiemTB<9)
            {
                return "Giỏi";
            }
            else
            {
                return "Xuất Xắc";
            }
        }
        public void xuat()
        {
            Console.WriteLine("Ma SV :" + this.maSV);
            Console.WriteLine("Ten SV :" + this.tenSV);
            Console.WriteLine("Diem TB : " + this.diemTB);
            Console.WriteLine("Hoc Luc :" + getHocLuc());
        }
    }
}
