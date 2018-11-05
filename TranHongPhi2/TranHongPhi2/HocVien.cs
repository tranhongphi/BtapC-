using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi2
{
    class HocVien:SinhVienHaUI
    {
        private int congNo;

        public HocVien():base()
        {
            this.congNo = 10000;
        }
        public HocVien(string ten, string gioiTinh, string que, bool coNY, int congNo):base(ten, gioiTinh, que, coNY)
        {
            this.congNo = congNo;
        }
        public int CongNo { get => congNo; set => congNo = value; }
        public int ThanhToan(int tienTT)
        {
            this.congNo = this.congNo - tienTT;
            return this.congNo;
        }
        public void xuat()
        {
            Console.Write("{0}\t {1}\t {2}\t {3}\t {4}", Ten, GioiTinh, Que, CoNY, this.congNo);
        }
    }
}
