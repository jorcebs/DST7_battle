using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalla
{
    abstract class SerVivo
    {
        private bool _vivo;
        public bool vivo { get { return _vivo; } }

        public SerVivo()
        {
            _vivo = true;
        }

        protected void morir()
        {
            _vivo = false;
        }

        public override string ToString()
        {
            return _vivo ? "vivo" : "muerto";
        }


    }
}