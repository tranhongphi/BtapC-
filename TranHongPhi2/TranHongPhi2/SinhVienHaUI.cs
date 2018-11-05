using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranHongPhi2
{
    class SinhVienHaUI
    {
        private string ten;
        private string gioiTinh;
        private string que;
        private bool coNY;

        public SinhVienHaUI()
        {
            this.ten = "NULL";
            this.gioiTinh = "NULL";
            this.que = "NULL";
            this.coNY = false;
        }
        public SinhVienHaUI(string ten, string gioiTinh, string que, bool coNY)
        {
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.que = que;
            this.coNY = coNY;
        }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Que { get => que; set => que = value; }
        public bool CoNY { get => coNY; set => coNY = value; }
    }
}
