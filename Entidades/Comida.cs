using System.Drawing;
using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes {ADHERESO, QUESO = 10, CEBOLLA = 8, LECHUGA = 7, TOMATE = 9, JAMON = 12, HUEVO = 13, PANCETA = 15}

        protected List<EIngredientes> ingredientes;
        protected string nombre;

        public double Costo { get { return CalcularCosto(); } }
        public string Descripcion { get { return  nombre; } }
        public string Nombre { get { return MostrarDatos(); } }

        protected abstract string AgregarIngrediente(EIngredientes ingrediente);
        protected abstract double CalcularCosto();
        protected Comida(string nombre) : this (nombre, new List<EIngredientes>())
        {
            
        }
        protected Comida(string nombre, List<EIngredientes> ingredientes)
        {
            this.nombre = nombre;
            this.ingredientes = ingredientes;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hamburguesa: {Nombre}");
            sb.AppendLine($"Precio: {Costo}");
            if(ingredientes.Count > 0)
            {
                foreach(var item in ingredientes)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("Sin ingredientes");
            }
            return sb.ToString();
        }

        public override bool Equals(Object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Comida c = (Comida)obj;
                return (this.Nombre == c.Nombre);
            }
        }

        public static bool operator ==(Comida c, EIngredientes i)
        {
            foreach(EIngredientes ingrediente in c.ingredientes)
            {
                if(i == ingrediente)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Comida c, EIngredientes i)
        {
            return !(c == i);
        }

        public static string operator +(Comida c, EIngredientes i)
        {
            return c.AgregarIngrediente(i);
        }



    }
}