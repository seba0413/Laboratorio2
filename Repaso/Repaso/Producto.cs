using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio; 

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string producto;
            producto = String.Format("Codigo: {0} \nMarca: {1}\nPrecio: {2}", p.codigoDeBarra, p.marca, p.precio);
            return producto;
        }

        public static explicit operator string(Producto p)
        {
            string codigo = p.codigoDeBarra;
            return codigo;
        }
        
        public static bool operator == (Producto p1, Producto p2)
        {
            return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
