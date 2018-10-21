using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    abstract class Guerrero : SerVivo
    {
        private static Random generador = new Random(); //si es una var estática se recomienda inicializar en la misma linea

        private string _nombre;
        protected int _blanco;

        public string nombre { get { return _nombre; } }

        public Guerrero(string nombre)
            // :base()
        {
            _nombre = nombre;
            _blanco = generador.Next(10);
        }

        public int disparar()
        {
            if (vivo)
                return generador.Next(10);
            else
                return -1;
        }

        public override string ToString()
        {
            return _nombre + " " + base.ToString();
        }


    }
}