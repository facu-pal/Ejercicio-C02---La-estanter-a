using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {producto.marca} - codigo De Barra:{(string)producto} - precio {producto.precio}");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto produc1, Producto produc2)
        {
            if (!(produc1 is null || produc2 is null))
            {
                return produc1.marca == produc2.marca && produc1.codigoDeBarra == produc2.codigoDeBarra;
            }

            return false;
        }

        public static bool operator !=(Producto produc1, Producto produc2)
        {

            return !(produc1 == produc2);
        }

        public static bool operator ==(Producto produc, string auxStr)
        {
            if (produc.codigoDeBarra == auxStr)
            {
                return true;
            }
            return produc.codigoDeBarra == auxStr;
        }

        public static bool operator !=(Producto produc1, string auxStr)
        {

            return !(produc1 == auxStr);
        }


    }

}
