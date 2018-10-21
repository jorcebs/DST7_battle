using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    class Terricola : Guerrero
    {
        private string _nombre;
        private static int _totalVivos;

        public int totalVivos { get { return _totalVivos; } }

        public Terricola(string nombre)
            :base(nombre)
        {
            _nombre = nombre;
            _totalVivos++;    
        }

        public void recibirDisparo(int disparo)
        {
            if (vivo && disparo == _blanco)
            {
                morir();
                _totalVivos--;
            }
        }

        public void nuevaTripulación()
        {
            _totalVivos = 0;
        }

        public void juegoNuevo()
        {
            _totalVivos = 0;
        }
    }
}