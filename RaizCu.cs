using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_ProgramacionNetEjercicios
{
    public class RaizCu
    {
        private double numero;

        public void setNumero(double valor)
        {

            this.numero = valor;
        }

        public double getNumero()
        {
            return this.numero;
        }

        public double Raiz()
        {
            return (Math.Sqrt(this.getNumero()));
        }
    }
}
