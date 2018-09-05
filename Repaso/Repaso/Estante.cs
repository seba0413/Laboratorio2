using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder informacion = new StringBuilder();

            foreach (Producto producto in e.productos)
            {
                informacion.AppendFormat("Codigo: {0}\nMarca: {1}\nPrecio: {2}", (String) producto, producto.GetMarca(), producto.GetPrecio());                 
            }
            return informacion.ToString();           
        }

        public static bool operator == (Estante estante, Producto producto)
        {
            bool seEncuentra = false; 

            foreach(Producto prodEst in estante.productos)
            {
                if (prodEst == producto)
                {
                    seEncuentra = true;
                    break;
                }
            }
            return seEncuentra;
        }

        public static bool operator != (Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator + (Estante estante, Producto producto)
        {
            bool tieneCapacidad = false; 

            if(estante != producto)
            {
                for(int i = 0; i < estante.productos.Length; i++)
                {
                    if(estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        tieneCapacidad = true;
                        break;
                    }
                }
            }
            return tieneCapacidad;
        }

        public static Estante operator - (Estante estante, Producto producto)
        {
            if(estante == producto)
            {
                for(int i = 0; i < estante.productos.Length; i++)
                {
                    if(estante.productos[i] == producto)
                    {
                        estante.productos[i] = null;
                        break; 
                    }
                }
            }
            return estante;
        }
    }
}
