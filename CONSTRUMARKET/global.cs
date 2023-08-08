using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CONSTRUMARKET
{
    public class global
    {
        public static List<Tipo_Compra> tipo_compra;
        public static List<Forma_Colocacion> forma_colocacion;
        public static List<Orden_Compra> orden_compra;
        public static List<Articulo> articulo;
        public static List<Orden_Compra_Articulo> orden_compra_articulos;

        public static List<Cliente> cliente = new List<Cliente>
        {
            new Cliente(1, "Axel Bellorin","bellorinaxel3@gmail.com", "Axel070801"),
            new Cliente(2, "Katherin Cuadras","katerin@gmail.com", "1234")
        };


        public class Cliente
        {
            int id;
            string nombre;
            string correo;
            string password;

            public Cliente(int id, string nombre, string correo, string password)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.Correo = correo;
                this.Password = password;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Correo { get => correo; set => correo = value; }
            public string Password { get => password; set => password = value; }
        }

        public class Tipo_Compra
        {
            int id;
            string nombre_Tipo_Compra;

            public Tipo_Compra(int id, string nombre_Tipo_Compra)
            {
                this.Id = id;
                this.Nombre_Tipo_Compra = nombre_Tipo_Compra;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre_Tipo_Compra { get => nombre_Tipo_Compra; set => nombre_Tipo_Compra = value; }
        }

        public class Forma_Colocacion
        {
            int id;
            string Nombre_Forma_Colocacion;

            public Forma_Colocacion(int id, string nombre_Forma_Colocacion)
            {
                this.Id = id;
                Nombre_Forma_Colocacion1 = nombre_Forma_Colocacion;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre_Forma_Colocacion1 { get => Nombre_Forma_Colocacion; set => Nombre_Forma_Colocacion = value; }
        }

        public class Articulo
        {
            int id;
            string Descripcion_Articulo;
            string Numero_Parte_Articulo;

            public Articulo(int id, string descripcion_Articulo, string numero_Parte_Articulo)
            {
                this.Id = id;
                Descripcion_Articulo1 = descripcion_Articulo;
                Numero_Parte_Articulo1 = numero_Parte_Articulo;
            }

            public int Id { get => id; set => id = value; }
            public string Descripcion_Articulo1 { get => Descripcion_Articulo; set => Descripcion_Articulo = value; }
            public string Numero_Parte_Articulo1 { get => Numero_Parte_Articulo; set => Numero_Parte_Articulo = value; }
        }

        public class Orden_Compra
        {
            int id;
            string Codigo_Orden_Compra;
            string Fecha_Estimada_Entrega;
            string Fecha_Compra;
            string Nombre_Equipo;
            int Cliente_Id;
            int Tipo_Compra_Id;
            int Forma_Colocacion_Id;

            public Orden_Compra(int id, string codigo_Orden_Compra, string fecha_Estimada_Entrega, string fecha_Compra, string nombre_Equipo, int cliente_Id, int tipo_Compra_Id, int forma_Colocacion_Id)
            {
                this.Id = id;
                Codigo_Orden_Compra1 = codigo_Orden_Compra;
                Fecha_Estimada_Entrega1 = fecha_Estimada_Entrega;
                Fecha_Compra1 = fecha_Compra;
                Nombre_Equipo1 = nombre_Equipo;
                Cliente_Id1 = cliente_Id;
                Tipo_Compra_Id1 = tipo_Compra_Id;
                Forma_Colocacion_Id1 = forma_Colocacion_Id;
            }

            public int Id { get => id; set => id = value; }
            public string Codigo_Orden_Compra1 { get => Codigo_Orden_Compra; set => Codigo_Orden_Compra = value; }
            public string Fecha_Estimada_Entrega1 { get => Fecha_Estimada_Entrega; set => Fecha_Estimada_Entrega = value; }
            public string Fecha_Compra1 { get => Fecha_Compra; set => Fecha_Compra = value; }
            public string Nombre_Equipo1 { get => Nombre_Equipo; set => Nombre_Equipo = value; }
            public int Cliente_Id1 { get => Cliente_Id; set => Cliente_Id = value; }
            public int Tipo_Compra_Id1 { get => Tipo_Compra_Id; set => Tipo_Compra_Id = value; }
            public int Forma_Colocacion_Id1 { get => Forma_Colocacion_Id; set => Forma_Colocacion_Id = value; }
        }
        
        public class Orden_Compra_Articulo
        {
            int id;
            int Cantidad;
            float Precio_Articulo;
            int Orden_Compra_Id;
            int Articulo_Id;

            public Orden_Compra_Articulo(int id, int cantidad, float precio_Articulo, int orden_Compra_Id, int articulo_Id)
            {
                this.Id = id;
                Cantidad1 = cantidad;
                Precio_Articulo1 = precio_Articulo;
                Orden_Compra_Id1 = orden_Compra_Id;
                Articulo_Id1 = articulo_Id;
            }

            public int Id { get => id; set => id = value; }
            public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
            public float Precio_Articulo1 { get => Precio_Articulo; set => Precio_Articulo = value; }
            public int Orden_Compra_Id1 { get => Orden_Compra_Id; set => Orden_Compra_Id = value; }
            public int Articulo_Id1 { get => Articulo_Id; set => Articulo_Id = value; }
        }

        //public class Conexion
        //{
        //    public static string conexion = ("Data Source = 169.254.249.207; Initial Catalog = seguimiento");
        //    public static SqlConnection conectar = new SqlConnection(conexion);


        //    public static bool Abrir()
        //    {
        //        if (conectar.State == ConnectionState.Closed)
        //        {
        //            conectar.Open();
        //            return true;
        //        }
        //        else
        //            return false;
        //    }

        //    public static void Cerrar()
        //    {
        //        if (conectar.State == ConnectionState.Open)
        //            conectar.Close();
        //    }


        //}
    }
}