using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_ProgramacionNetEjercicios
{
    public class MosrarEdad
    {
        private int edad;

        public void setEdad(int valor)
        {
            this.edad = valor;
        }

        public int getEdad()
        {
            return this.edad;
        }


        public int muestralaEdad()
        {
            return (this.getEdad());
        }
    }
}
