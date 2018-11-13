using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btapthaythe
{
    class Ong
    {
        protected double hp;
        protected bool chet;

        public Ong()
        {
            this.hp = 100;
            this.chet = false;
        }
        public double Hp { get => hp; }
        public double Danh(int hp)
        {
            if(this.chet==false)
            {
                return this.hp -= hp;
            }
            return this.hp;
        }
    }
}
