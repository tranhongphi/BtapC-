using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi2
{
    class Leader:SinhVienHaUI
    {
        private string chucVu;

        public Leader():base()
        {
            this.chucVu = "NULL";
        }
        public Leader(string ten, string gioiTinh, string que, bool coNY, string chucVu):base(ten, gioiTinh, que, coNY)
        {
            this.chucVu = chucVu;
        }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public void xuat()
        {
            Console.Write("{0}\t {1}\t {2}\t {3}\t {4}", Ten, GioiTinh, Que, CoNY, this.chucVu);
        }
    }
}
