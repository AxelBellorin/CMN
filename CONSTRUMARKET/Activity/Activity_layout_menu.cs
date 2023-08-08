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

namespace CONSTRUMARKET
{
    [Activity(Label = "Activity_layout_menu")]
    public class Activity_layout_menu : Activity
    {
        Button btn_pedido, btn_cotizacion;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout_menu);

            /*btn_pedido= FindViewById<Button> (Resource.Id.button1);
            btn_cotizacion = FindViewById<Button>(Resource.Id.button2);*/

            btn_pedido.Click += Btn_pedido_Click;
            btn_cotizacion.Click += Btn_cotizacion_Click;   
        }

        private void Btn_cotizacion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_pedido_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Activity_layout_order));
            StartActivity(intent);
        }
    }
}