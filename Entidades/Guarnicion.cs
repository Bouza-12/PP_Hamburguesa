using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo { PAPAS_FRITAS = 1000, ENSALADA_RUSA = 750, ENSALADA_MIXTA = 500}

        private ETipo tipo;

        public Guarnicion(ETipo tipo) : base(tipo.ToString()) 
        {
            this.tipo = tipo;
        }
        public Guarnicion():this(ETipo.PAPAS_FRITAS) { }

        public override string ToString()
        {
            return $"Guarnicion de tipo { this.tipo.ToString()}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }

        public static bool operator ==(Guarnicion g, EIngredientes i)
        {
            return i == EIngredientes.ADHERESO || i == EIngredientes.QUESO || i == EIngredientes.PANCETA;
        }
        public static bool operator !=(Guarnicion g, EIngredientes i)
        {
            return !(g == i);
        }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            if( this == ingrediente)
            {
                foreach(EIngredientes i in base.ingredientes)
                {
                    if(i== ingrediente)
                    {
                        return $"No se pudo agregar {ingrediente.ToString()} a su guarnición";
                    }

                }
                this.ingredientes.Add(ingrediente);
                return $"Se agrego {ingrediente.ToString()} a su guarnicion";
            }
            return $"No se pudo agregar {ingrediente.ToString()} a su guarnición";
        }
        protected override double CalcularCosto()
        {
            double precio = (int)tipo;
            foreach (EIngredientes i in ingredientes)
            {
                double porcentajeAgregado = 1 + ((double)i / 100);

                precio += (porcentajeAgregado + (double)tipo);
            }
            return precio;
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }


    }
}
