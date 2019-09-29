using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1_ProgramacionNetEjercicios
{
    class Valor
    {
        private int producto;


        public void setProducto(int valor)
        {
            this.producto = valor;
        }

        public int getProducto()
        {
            return this.producto;
        }

        public double descuento()
        {
            return (this.producto * 0.2);
        }

        public double iva()
        {
            return (this.producto * 0.19);
        }

        public double totalproducto()
        {
            return ((this.descuento() + this.getProducto()) + this.iva());
        }
    }
}
