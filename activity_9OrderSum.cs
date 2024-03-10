using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _607A2
{
    [Activity(Label = "activity_9OrderSum")]
    public class activity_9OrderSum : Activity
    {

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_9OrderSum);
            ImageView home = FindViewById<ImageView>(Resource.Id.Sc9Back);
            home.Click += Home_Click;
        }

        void Home_Click(object? sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    


    }
}