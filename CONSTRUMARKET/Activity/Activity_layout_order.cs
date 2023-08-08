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
using CONSTRUMARKET;
using static CONSTRUMARKET.global;

namespace CONSTRUMARKET
{
    [Activity(Label = "Activity_layout_order")]
    public class Activity_layout_order : Activity
    {
        ListView lv_order;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout_order);

            //lv_order = FindViewById<ListView>(Resource.Id.listView1);
            //lv_order.Adapter = new adapter_Order(this ,orden_compra, orden_compra_articulos);
            //lv_order.ItemClick += Lv_order_ItemClick;    


        }

        //private void Lv_order_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        //{
        //    Intent intent = new Intent(this, typeof(Activity_Detail_Order));

        //    int id_order = orden_compra[e.Position].Id;

        //    intent.PutExtra("id_order", id_order);
        //    StartActivity(intent);
        //}
    }
}