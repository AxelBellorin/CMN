using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CONSTRUMARKET.global;

namespace CONSTRUMARKET
{
    class adapter_Order : BaseAdapter
    {
        Activity context;
        List<Orden_Compra> orden_compra;
        List<Orden_Compra_Articulo> orden_compra_articulos;

        public adapter_Order (Activity context, List<Orden_Compra> orden_compra, List<Orden_Compra_Articulo> orden_compra_articulo)
        {
            this.context = context;
            this.orden_compra = orden_compra;
            this.orden_compra_articulos = orden_compra_articulo;
        }

        public override int Count => orden_compra.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = orden_compra[position];

            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.adapter_Order, null);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = "ID: " + item.Codigo_Orden_Compra1;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = "Fecha: " + item.Fecha_Compra1;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = "Fecha estimada de entrega: " + item.Fecha_Estimada_Entrega1;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = "Monto: " + orden_compra_articulos.Where(x=> x.Orden_Compra_Id1 == item.Id).Sum(x=>x.Precio_Articulo1*x.Cantidad1);
            view.FindViewById<TextView>(Resource.Id.textView5).Text = "Equipo: " + item.Nombre_Equipo1;

            return view;
        }
    }
}