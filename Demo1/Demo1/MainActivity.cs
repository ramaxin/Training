using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace Demo1
{
    [Activity(Label = "Demo1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TextView tvDemo;
        private EditText txtDemo;
        private Button btnDemo,btnChuyenTrang;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            tvDemo = FindViewById<TextView>(Resource.Id.tvDemo);
            txtDemo = FindViewById<EditText>(Resource.Id.txtDemo);
            btnDemo = FindViewById<Button>(Resource.Id.btnDemo);
            btnChuyenTrang = FindViewById<Button>(Resource.Id.btnChuyenTrang);
            btnDemo.Click += demo;
            btnChuyenTrang.Click += chuyentrang;

        }

        private void chuyentrang(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(DetailActivity));
            var giatri = txtDemo.Text;
            intent.PutExtra("p1", giatri);
            StartActivity(intent);
        }

        private void demo(object sender, EventArgs e)
        {
           //
            tvDemo.Text = txtDemo.Text;
        }
    }
}

