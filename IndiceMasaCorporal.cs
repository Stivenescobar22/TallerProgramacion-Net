using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_ProgramacionNetEjercicios
{
    public class IndiceMasaCorporal
    {

        private double Estatura;
        private double Peso;

        public void setEstatura(double valor)
        {

            this.Estatura = valor;

        }

        public double getEstatura()
        {

            return this.Estatura;
        }

        public void setPeso(double valor)
        {

            this.Peso = valor;
        }

        public double getPeso()
        {

            return this.Peso;
        }

        public double Calcular()
        {

            return (this.getPeso() /( this.getEstatura() * this.getEstatura()) * 10000 );
        }

    }
}
