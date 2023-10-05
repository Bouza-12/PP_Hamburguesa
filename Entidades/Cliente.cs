using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        private double TotalAPagar
        {
            get 
            { 
                double total = 0;
                foreach(Comida com in menu)
                {
                    total += com.Costo;
                }
                return total; 
            }
        }

        private Cliente (int dni)
        {
            this.dni = dni;
            this.menu = new List<Comida> ();
        }

        public static implicit operator Cliente(int dni)
        {
            return new Cliente(dni);
        }


        public static Cliente GetCliente(int dni)
        {
            return (Cliente) dni;
        }

        public Comida BuscarComida(Comida comida)
        {
            foreach(Comida com in menu)
            {
                if (com.Equals(comida))
                {
                    return com;
                }
            }
            return null;
        }

        public static bool operator ==(Cliente cliente, Comida comida)
        {
            return cliente.menu.Contains(comida);
        }
        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }

        public static Cliente operator +(Cliente cliente, Comida comida)
        {
            if(cliente != comida)
            {
                cliente.menu.Add(comida);    
            }
            return cliente;
        }

        public static string ImprimirTicket(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(cliente.dni.ToString());
            foreach(Comida comida in cliente.menu)
            {
                sb.AppendLine(comida.Descripcion);
            }
            sb.AppendLine(cliente.TotalAPagar.ToString());
            return sb.ToString();
        }



    }
}
