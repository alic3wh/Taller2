using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    class Player
    {
        private int vida;
        private int dano;

        public void Status(int vida, int dano)
        {
            this.vida = vida;
            this.dano = dano;
        }

        public void RecibirDano(int danoE)
        {
            vida = vida - danoE;

        }
        public int GetDano()
        {
            return dano;
        }




    }



}
