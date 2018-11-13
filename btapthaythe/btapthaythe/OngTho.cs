using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class OngTho:Ong
    {
        public void trangThai()
        {
            if (this.hp < 50)
            {
                this.chet = true;
                Console.WriteLine("Ong tho, da chet, hp = " + this.hp);
            }
            else
            {
                this.chet = false;
                Console.WriteLine("Ong tho, con song, hp = " + this.hp);
            }
        }
    }
}
