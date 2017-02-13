using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Views;
using System;

namespace Android_demo1
{
    [Activity(Label = "Android_demo1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText txtTest;
        private TextView tvTest;
        private Button btnTest;
        private Button btnDetail;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            txtTest = FindViewById<EditText>(Resource.Id.txtTest);
            tvTest = FindViewById<TextView>(Resource.Id.lblTest);
            btnTest = FindViewById<Button>(Resource.Id.btnTest);
            btnDetail = FindViewById<Button>(Resource.Id.btnDetail);
            btnTest.Click += myButtonClick;
            btnDetail.Click += myDetailClick; 
            //Ghi chu
        }

        private void myDetailClick(object sender, EventArgs e)
        {
            string vDetail = txtTest.Text;
            var intend = new Intent(this,typeof(DetailActivity));
            intend.PutExtra("p1", vDetail);
            StartActivity(intend);
        }

        private void myButtonClick(object sender, EventArgs e)
        {
            tvTest.Text = txtTest.Text;
        }
    }
}

