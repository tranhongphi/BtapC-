using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class QuanLyOng
    {
        private List<OngDuc> dsOngDuc = new List<OngDuc>();
        private List<OngChua> dsOngChua = new List<OngChua>();
        private List<OngTho> dsOngTho = new List<OngTho>();
        public void taoDanhSachOng()
        {
            dsOngDuc.Clear();
            dsOngChua.Clear();
            dsOngTho.Clear();
            Random rd = new Random();
            for (int i=0; i<5; i++)
            {
                int random = rd.Next(1, 4);
                if(random==1)
                {
                    OngDuc a = new OngDuc();
                    dsOngDuc.Add(a);
                }
                else if(random==2)
                {
                    OngChua b = new OngChua();
                    dsOngChua.Add(b);
                }
                else if(random==3)
                {
                    OngTho c = new OngTho();
                    dsOngTho.Add(c);
                }
            }
        }
        public void xuatDanhSachOng()
        {
            if(dsOngDuc != null)
            {
                for(int i=0; i<dsOngDuc.Count; i++) {
                    dsOngDuc[i].trangThai();
                }
            }
            if (dsOngChua != null)
            {
                for (int i = 0; i < dsOngChua.Count; i++)
                {
                    dsOngChua[i].trangThai();
                }
            }
            if (dsOngTho != null)
            {
                for (int i = 0; i < dsOngTho.Count; i++)
                {
                    dsOngTho[i].trangThai();
                }
            }
        }
        public void tanCong()
        {
            Random rd = new Random();
            if (dsOngDuc.Count != 0)
            {
                for (int i = 0; i < dsOngDuc.Count; i++)
                {
                    int random = rd.Next(0, 80);
                    dsOngDuc[i].Danh(random);
                }
            }
            if (dsOngChua.Count != 0)
            {
                for (int i = 0; i < dsOngChua.Count; i++)
                {
                    int random = rd.Next(0, 80);
                    dsOngChua[i].Danh(random);
                }
            }
            if (dsOngTho.Count != 0)
            {
                for (int i = 0; i < dsOngTho.Count; i++)
                {
                    int random = rd.Next(0, 80);
                    dsOngTho[i].Danh(random);
                }
            }
            Console.WriteLine("trang thai sau khi tan cong");
            xuatDanhSachOng();
        }
    }
}