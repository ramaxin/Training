using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Demo1
{
    [Activity(Label = "DetailActivity")]
    public class DetailActivity : Activity
    {
        private TextView tvDetail;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Detail);
            tvDetail = FindViewById<TextView>(Resource.Id.tvDetail);
            string text = Intent.GetStringExtra("p1") ?? "Null";

            tvDetail.Text = text;
            // Create your application here
        }
    }
}