using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _607A2
{
    [Activity(Label = "activity_4Profile")]
    public class activity_4Profile : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_4Profile);
            ImageView home = FindViewById<ImageView>(Resource.Id.Sc4Back);
            home.Click += Home_Click;
        }
        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }

    }
}