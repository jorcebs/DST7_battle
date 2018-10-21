using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    class Marciano : Guerrero
    {
        private static int _totalVivos;
        public int totalVivos { get { return _totalVivos; } }

        public Marciano(string nombre)
            :base(nombre)
        {
            _totalVivos++;
        }

        public void recibirDisparo(int disparo)
        {
            if(vivo && disparo == _blanco)
            {
                morir();
                _totalVivos--;
            }
        }

        public void juegoNuevo()
        {
            _totalVivos = 0;
        }
    }
}