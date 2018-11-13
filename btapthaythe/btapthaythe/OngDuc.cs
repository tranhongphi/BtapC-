using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class OngDuc:Ong
    {
        public void trangThai()
        {
            if (this.hp < 50)
            {
                this.chet = true;
                Console.WriteLine("Ong duc, da chet, hp = " + this.hp);
            }
            else
            {
                this.chet = false;
                Console.WriteLine("Ong duc, con song, hp = " + this.hp);
            }
        }
    }
}
