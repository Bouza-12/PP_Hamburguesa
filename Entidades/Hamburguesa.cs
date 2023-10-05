using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        static Hamburguesa()
        {
            costoBase = 1500;
        }

        public Hamburguesa(string nombre, bool esDoble) : base(nombre)
        {
            this.esDoble = esDoble;
        }
        public Hamburguesa(string nombre) : this(nombre, false) { }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            if((Comida)this == ingrediente)
            {
                return $"No se pudo agregar {ingrediente} a su hamburguesa";
            }
            else
            {
                this.ingredientes.Add(ingrediente);
                return $"Se agrego {ingrediente} a su hamburguesa";
            }
        }

        public override string ToString()
        {
            if (esDoble)
            {
                return "Hamburguesa - Doble";
            }
            else
            {
                return "Hamburguesa - Simple";
            }
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
            
        }

        protected override double CalcularCosto()
        {
            double precio = costoBase;
            if (esDoble) { precio += 500 ; }
            foreach(EIngredientes i in ingredientes)
            {
                double porcentajeAgregado = ((double)i / 100) ;
                double costoAgregado = costoBase * porcentajeAgregado;
                precio += (costoAgregado);
            }
            return precio;

        }



    }
}
