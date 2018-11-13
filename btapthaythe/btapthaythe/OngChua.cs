using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class OngChua:Ong
    {
        public void trangThai()
        {
            if(this.hp<20)
            {
                this.chet = true;
                Console.WriteLine("Ong chua, da chet, hp = " + this.hp);
            }
            else
            {
                this.chet = false;
                Console.WriteLine("Ong chua, con song, hp = " + this.hp);
            }
        }
    }
}
