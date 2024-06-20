using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int y, int x)                 
        {                                             
            this.x = x;
            this.y = y;
        }

        public int GetX { get => x; }
        public int GetY { get => y; }
    }
}
