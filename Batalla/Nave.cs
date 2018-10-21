using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    class Nave
    {
        private string _somos;
        private Guerrero[] tripulación = new Guerrero[10];

        public Nave(string somos)
        {
            _somos = somos;
            if (_somos == "Terricolas")
            {
                for (int i = 0; i < 10; i++)
                    tripulación[i] = new Terricola("T" + i);
                ((Terricola)tripulación[0]).juegoNuevo();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    tripulación[i] = new Marciano("M" + i);
                ((Marciano)tripulación[0]).juegoNuevo();
            }
        }

        public int generarDisparo(int turno)
        {
            return tripulación[turno].disparar();
        }

        public void recibirDisparo(int disparo)
        {
            if (_somos == "Terricolas")
                for (int i = 0; i < 10; i++)
                    ((Terricola)tripulación[i]).recibirDisparo(disparo);
            else
                for (int i = 0; i < 10; i++)
                    ((Marciano)tripulación[i]).recibirDisparo(disparo);
        }

        public int cuantosQuedan()
        {
            if (_somos == "Terricolas")
                return ((Terricola)tripulación[0]).totalVivos;
            else
                return ((Marciano)tripulación[0]).totalVivos;
        }


    }
}