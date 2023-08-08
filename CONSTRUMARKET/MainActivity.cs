using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using CONSTRUMARKET;
using System.Linq;
using System.Collections.Generic;

namespace CONSTRUMARKET
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn2;
        EditText correo, password;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout_login);

            //btn_login = FindViewById<Button>(Resource.Id.btn_login);
            btn2 = FindViewById<Button>(Resource.Id.btn_login);
            correo = FindViewById<EditText>(Resource.Id.et_correo);
            password = FindViewById<EditText>(Resource.Id.et_password);

            //btn_login.Click += Btn_login_Click;
            btn2.Click += Btn_login_Click;
        }

        private void Btn_login_Click(object sender, System.EventArgs e)
        {
            if (correo.Text != "" && password.Text != "")
            {
                List<global.Cliente> clientes = new List<global.Cliente>();

                clientes = global.cliente.Where(x => x.Correo == correo.Text && x.Password == password.Text).ToList();

                if (clientes.Count > 0)
                {
                    Toast.MakeText(this, "Bienvenido", ToastLength.Long).Show();
                    Intent intent = new Intent(this, typeof(Activity_layout_menu));
                    StartActivity(intent);
                }
                else
                    Toast.MakeText(this, "Usuario o contraseña incorrecta", ToastLength.Long).Show();
                
            }
            else
                Toast.MakeText(this, "No dejar en blanco el campo correo o contraseña", ToastLength.Long).Show();
        }




        //private void Btn2_Click(object sender, System.EventArgs e)
        //{
        //    var user2 = global.user.Exists(x => x.Correo == correo.Text && x.Password == password.Text);

        //    if (correo.Text != "" && password.Text != "")
        //    {
        //        Toast.MakeText(this, "Inicio de sesion exitoso", ToastLength.Long).Show();
        //        Intent intent = new Intent(this, typeof(Activity_layout_menu));
        //        StartActivity(intent);
        //    }
        //    else
        //        Toast.MakeText(this, "Usuario o contraseña incorrecta", ToastLength.Long).Show();
        //}

        //private void Btn_login_Click(object sender, System.EventArgs e)
        //{
        //    if (global.user.Exists(x => x.Correo == correo.Text && x.Password == password.Text))
        //    {
        //        Toast.MakeText(this, "Error", ToastLength.Long);
        //        Intent intent = new Intent(this, typeof(Activity_layout_menu));
        //        StartActivity(intent);
        //    } 
        //    else
        //        Toast.MakeText(this, "Usuario o contraseña incorrecta", ToastLength.Long);
        //}



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}