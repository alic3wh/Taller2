using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1
{
    class Enemy
    {
        private int vidaE;
        private int danoE;

        public void StatusE(int vidaE, int danoE)
        {
            this.vidaE = vidaE;
            this.danoE = danoE;
        }

        public void RecibirDano(int dano)
        {
            vidaE = vidaE - dano;
        }

        public int DanoE()
        {
            return danoE;
        }

        public bool VivoOMuerto()
        {
            bool Vivo;
            if (vidaE > 0)
            {
                Vivo = true;
            }
            else
            {
                Vivo = false;
            }
            return Vivo;
        }
    }



}
