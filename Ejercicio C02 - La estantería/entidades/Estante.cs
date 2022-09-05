﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante (Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicado en: {estante.ubicacionEstante}");

            foreach (Producto item in estante.productos)
            {
                if (!ReferenceEquals(item, null))
                {
                    sb.AppendLine(Producto.MostrarProducto(item));
                    sb.AppendLine("----------------------");

                }
            }


            return sb.ToString();
        }

        public static bool operator ==(Estante estante, Producto producto)
        {

            foreach (Producto item in estante.productos)
            {
                if (item == producto)
                {
                    return true;

                }
            }

            return false;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {

            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;

                    }
                }
            }

            return false;
        }
        public static Estante operator -(Estante estante, Producto producto)
        {

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante == producto)
                {
                    estante.productos[i] = null;
                    break;
                }
            }
            return estante;

        }
    }
}
